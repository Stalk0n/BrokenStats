using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using BrokenStats.Tables;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers;
using ScottPlot.WinForms;
using ScottPlot;

namespace BrokenStats
{
    public partial class MainForm : Form
    {
        private LogsContext? _dbContext;

        private System.Windows.Forms.Timer timer;

        double[] dataX = new double[0];
        double[] dataY = new double[0];


        public MainForm()
        {
            Uruchom_sniffer();
            InitializeComponent();
            Sniffer.ChatLogPacketFound += OnChatLogPackedFound;
            Sniffer.BattleLogPackedFound += OnBattleLogPacketFound;


            //viewModel = new ChartViewModel();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //formsPlot1.MouseDown += formsPlot1_MouseDown;
            formsPlot1.MouseUp += formsPlot1_MouseUp;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            CreateChart();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; 
            timer.Tick += Timer_Tick;

            timer.Start();
        }
        private void CreateChart()
        {
            formsPlot1.Plot.XLabel("Timeline");
            formsPlot1.Plot.YLabel("XP");

            //var viewLimits = formsPlot1.Plot.Axes;
            //MessageBox.Show(viewLimits.ToString());
            //formsPlot1.Plot.Axes.SetLimitsY(0,maxY);
            formsPlot1.Plot.Axes.Bottom.TickGenerator = myTickGenerator;


            formsPlot1.Refresh();
        }


        private void formsPlot1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formsPlot1.Interaction.Disable();
            }
        }
        private void formsPlot1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formsPlot1.Interaction.Enable();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_dbContext != null)
            {
                double averageXP = _dbContext.GetAverageXPForLastXseconds();

                // Dodaj nowy wpis do tabeli ChartSeries
                var newEntry = new ChartSeries
                {
                    Data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Experience = averageXP
                };

                // Sprawdź, czy liczba wpisów w tabeli przekracza 120
                if (_dbContext.ChartSerie.Count() >= 120)
                {
                    // Jeśli tak, usuń najstarszy wpis
                    var oldestEntry = _dbContext.ChartSerie.OrderBy(entry => entry.Data).FirstOrDefault();
                    if (oldestEntry != null)
                    {
                        _dbContext.ChartSerie.Remove(oldestEntry);

                    }

                }
                // Dodaj nowy wpis do bazy danych i zapisz zmiany

                _dbContext.ChartSerie.Add(newEntry);
                chart_label.Text = "Tyle punktów na wykresie: " + (_dbContext.ChartSerie.Count()).ToString();
                _dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Brak dostępu do bazy danych.");
            }

            UpdateChart();
        }

        private void UpdateChart()
        {
            // Pobierz najnowsze dane z tabeli ChartSeries
            var xpData = _dbContext.ChartSerie.OrderBy(x => x.LogId).Select(x => x.Experience).ToList();

            // Przekonwertuj listę double na listę int
            var xpDataInt = xpData.Select(x => (int)x);

            // Aktualizuj dane na wykresie
            UpdateData(xpDataInt);
        }

        public void UpdateData(IEnumerable<int> xpValues)
        {
            // Sprawdź, czy ilość danych jest wystarczająca do wygenerowania ticków na osi OX

            // Obliczamy różnicę w czasie między obecnym czasem a czasem dla każdego punktu danych
            var currentTime = DateTime.Now;
            var timeDifferences = Enumerable.Range(0, xpValues.Count())
                                            .Select(i => -30 * (xpValues.Count() - 1 - i)); // Przesunięcie w czasie, np. -5 * (n - 1) dla n punktów danych

            // Aktualizujemy dane na wykresie
            dataX = timeDifferences.Select(Convert.ToDouble).ToArray();
            dataY = xpValues.Select(Convert.ToDouble).ToArray();
            formsPlot1.Plot.Clear();

            formsPlot1.Plot.Add.Scatter(dataX, dataY);
            formsPlot1.Refresh();

            formsPlot1.Plot.Axes.AutoScale();


            AxisLimits limits = formsPlot1.Plot.Axes.GetLimits();
            double yMax = limits.Top;
            double yMin = limits.Bottom;

            formsPlot1.Plot.Axes.SetLimits(null,null, yMin - 0.5, yMax + 5);
            //var limits = formsPlot1.Plot.Axes.GetLimits();

            // Maximum Y value
            //double maxY = limits.Top;

            //formsPlot1.Plot.Axes.SetLimitsY(0, maxY); // set the lower limit of Y-axis to 0



        }

        // create a static function containing the string formatting logic
        static string CustomFormatter(double position)
        {
            // Jeśli wartość na osi X jest mniejsza niż 1 minuta, wyświetl w sekundach
            if (position > -60)
            {
                // Konwertuj pozycję na sekundy
                int seconds = (int)(position);

                // Formatuj wartość na osi X jako -(liczba)sec
                return $"{seconds}sec";
            }
            else
            {
                // Konwertuj pozycję na minutę
                int minutes = (int)(position / 60);

                // Formatuj wartość na osi X jako -(liczba)min
                return $"{minutes}min";
            }
        }






        ScottPlot.TickGenerators.NumericAutomatic myTickGenerator = new()
        {
            LabelFormatter = CustomFormatter
        };

        private double GetXPData()

        {
            return 0;
        }





        private static void Uruchom_sniffer()
        {
            Sniffer sniffer = new Sniffer();

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                sniffer.Start();
            }).Start();
        }


        private void OnChatLogPackedFound(string packetData)
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => OnChatLogPackedFound(packetData)));
                return;
            }

            if (_dbContext != null)
            {
                _dbContext.AddChatLogMessage(packetData);
                _dbContext.SaveChanges();

                _dbContext.ChatLogNicknames.Load();
                chatLogNicknameBindingSource.DataSource = _dbContext.ChatLogNicknames.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show("Brak dostępu do bazy danych.");
            }
        }


        private void OnBattleLogPacketFound(string packetData)
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => OnBattleLogPacketFound(packetData)));
                return;
            }

            if (_dbContext != null)
            {
                _dbContext.AddBattleLogInstance(packetData);
                string[] parts = packetData.Split('\t');

                if ((int.TryParse(parts[1], out int number)) && _dbContext != null && !string.IsNullOrWhiteSpace(parts[1]))
                {
                    _dbContext.AddXP(number);
                }
                _dbContext.SaveChanges();

                _dbContext.BattleLogNicknames.Load();
                battleLogNicknameBindingSource.DataSource = _dbContext.BattleLogNicknames.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show("Brak dostępu do bazy danych.");
            }
        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _dbContext = new LogsContext();

            // Uncomment the line below to start fresh with a new database.
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();

            _dbContext.ChatLogNicknames.Load();

            _dbContext.BattleLogNicknames.Load();

            chatLogNicknameBindingSource.DataSource = _dbContext.ChatLogNicknames.Local.ToBindingList();

            battleLogNicknameBindingSource.DataSource = _dbContext.BattleLogNicknames.Local.ToBindingList();

            Timer_Tick(null, null);





        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void dataGridViewNicknames_SelectionChanged(object sender, EventArgs e)
        {
            if (_dbContext != null)
            {
                var nickname = (ChatLogNickname)dataGridViewChatNickname.CurrentRow!.DataBoundItem;

                if (nickname != null)
                {
                    _dbContext.Entry(nickname).Collection(e => e.Messages).Load();
                }
            }
        }


        private void dataGridViewNicknames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_dbContext != null)
            {
                _dbContext.AddChatLogMessage("Mateusz PIWO");
                _dbContext.SaveChanges();

                // Odœwie¿anie danych w formularzu
                _dbContext.ChatLogNicknames.Load();
                chatLogNicknameBindingSource.DataSource = _dbContext.ChatLogNicknames.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show("Brak dostêpu do bazy danych.");
            }
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;

            if ((int.TryParse(text, out int number)) && _dbContext != null && !string.IsNullOrWhiteSpace(text))
            {
                _dbContext.AddXP(number);
                _dbContext.SaveChanges();

            }



        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formsPlot1.Refresh();

            formsPlot1.Plot.Axes.AutoScale();


            AxisLimits limits = formsPlot1.Plot.Axes.GetLimits();
            double yMax = limits.Top;
            double yMin = limits.Bottom;


            formsPlot1.Plot.Axes.SetLimits(null, null, yMin - 0.5, yMax + 5);

        }
    }
}
