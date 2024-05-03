using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using BrokenStats.ViewModels;
using BrokenStats.Tables;



namespace BrokenStats
{
    public partial class MainForm : Form
    {
        private LogsContext? _dbContext;

        private ChartViewModel _chartViewModel;
        private System.Windows.Forms.Timer timer;

        public MainForm()
        {
            Uruchom_sniffer();
            InitializeComponent();
            Sniffer.ChatLogPacketFound += OnChatLogPackedFound;
            Sniffer.BattleLogPackedFound += OnBattleLogPacketFound;


            InitializeChart();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 3000 milisekund = 3 sekundy
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_dbContext != null)
            {
                // Oblicz obecną godzinę
                var currentTime = DateTime.UtcNow;

                // Oblicz początkową godzinę (godzinę wcześniej niż obecna)
                var startTime = currentTime.AddHours(-1);

                // Oblicz różnicę czasu w sekundach
                var diffInSeconds = (int)(currentTime - startTime).TotalSeconds;

                // Pobierz wszystkie dane z tabeli XPtable, które są w zakresie ostatniej godziny
                var xpData = _dbContext.XPtable
                    .Where(x => EF.Functions.Like(x.Data, $"{startTime:yyyy-MM-dd HH:mm:ss}%"))
                    .OrderBy(x => x.Data)
                    .ToList();

                // Zainicjuj listę, która będzie przechowywać dane na wykresie
                List<double> xpValues = new List<double>();

                // Uzupełnij listę danymi z XPtable
                var timePointer = startTime;
                foreach (var xpRecord in xpData)
                {
                    // Dopóki nie dojdziemy do aktualnego czasu, wypełniaj braki zerami
                    while (timePointer < currentTime && timePointer < DateTime.Parse(xpRecord.Data))
                    {
                        xpValues.Add(0);
                        timePointer = timePointer.AddSeconds(3); // Dodaj 3 sekundy do wskaźnika czasu
                    }

                    // Dodaj wartość do listy
                    xpValues.Add(xpRecord.Experience);
                    timePointer = timePointer.AddSeconds(3); // Dodaj 3 sekundy do wskaźnika czasu
                }

                // Dopóki nie osiągniemy aktualnego czasu, wypełniaj braki zerami
                while (timePointer <= currentTime)
                {
                    xpValues.Add(0);
                    timePointer = timePointer.AddSeconds(3); // Dodaj 3 sekundy do wskaźnika czasu
                }

                // Aktualizuj dane na wykresie
                _chartViewModel.UpdateData(xpValues);

                // Odśwież wyświetlanie wykresu
                cartesianChart1.Update();
            }
        }





        private void InitializeChart()
        {
            _chartViewModel = new ChartViewModel();
            cartesianChart1.Series = _chartViewModel.Series;

            // Tutaj możesz dostosować ustawienia wykresu
            // Na przykład osie, etykiety itp.
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
    }
}
