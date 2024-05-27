using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace BrokenStats.UserControls;

public partial class UC_Respawns : UserControl
{
    private readonly SoundPlayer ping = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sounds", "ping.wav"));

    private readonly List<CharacterRespawnInfo> respawnList = new();
    private int timerNumber = 1;

    public UC_Respawns()
    {
        InitializeComponent();
        InitializeRespawnList();
        InitializeTableLayoutPanel();
    }

    // Metoda inicjalizująca listę postaci z ich czasami respawnu, obrazkami i Timerami
    private void InitializeRespawnList()
    {
        string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
        Directory.SetCurrentDirectory(projectDirectory);
        // Dodaj postacie wraz z ich czasami respawnu, obrazkami i Timerami
        var imagePath = Path.Combine(projectDirectory, "Images", "Bibliotekarz.png");
        respawnList.Add(new CharacterRespawnInfo("Bibliotekarz", TimeSpan.FromSeconds(10),
            Image.FromFile(imagePath))); // Dodaj inne postacie zgodnie z potrzebami
    }

    // Metoda sprawdzająca czy dany mob jest na liście championów i uruchamiająca odpowiedni minutnik
    private void CheckChampionList(string mobName)
    {
        var champion = respawnList.FirstOrDefault(character => character.CharacterName == mobName);
        if (champion != null)
        {
            // Jeśli mob jest na liście championów, uruchom odpowiedni minutnik
            champion.StartTimer();
            AddTimerToLayoutPanel(champion);
        }
    }

    // Metoda dodająca Timer do TableLayoutPanel
    private void AddTimerToLayoutPanel(CharacterRespawnInfo character)
    {
        // Szukaj wolnej komórki w lewym górnym rogu
        for (var col = 0; col < tableLayoutPanel1.ColumnCount - 2; col++)
        for (var row = 0; row < tableLayoutPanel1.RowCount; row++) // Zwiększaj kolumnę o 2, aby dodawać panele w parach
            if (tableLayoutPanel1.GetControlFromPosition(col, row) == null)
            {
                var numberPanel = new Panel();
                numberPanel.Dock = DockStyle.Fill;
                var numberLabel = new Label();
                numberLabel.Text = timerNumber.ToString(); // Ustaw numer timera
                numberLabel.Dock = DockStyle.Fill;
                numberLabel.AutoSize = false;
                numberLabel.TextAlign = ContentAlignment.MiddleCenter; // Wyśrodkuj tekst w etykiecie
                numberPanel.Controls.Add(numberLabel);

                // Znaleziono wolną komórkę, dodaj panele w parach
                var leftPanel = new Panel();
                leftPanel.Dock = DockStyle.Fill;
                var pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = character.CharacterImage;
                leftPanel.Controls.Add(pictureBox);
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

                var rightPanel = new Panel();
                rightPanel.Dock = DockStyle.Fill;
                var timeLabel = new Label();
                timeLabel.Text = character.RespawnTime.ToString(); // Ustawienie początkowego czasu respawnu
                timeLabel.Dock = DockStyle.Fill;
                timeLabel.AutoSize = false;
                timeLabel.TextAlign = ContentAlignment.MiddleLeft; // Wyśrodkuj tekst w etykiecie
                rightPanel.Controls.Add(timeLabel);

                tableLayoutPanel1.Controls.Add(numberPanel, col, row);
                tableLayoutPanel1.Controls.Add(leftPanel, col + 1, row);
                tableLayoutPanel1.Controls.Add(rightPanel, col + 2, row);

                // Utwórz nowy timer dla danego bohatera z osobnym czasem inicjalizacji
                var respawnTimer = new Timer();
                var initialRespawnTime = character.RespawnTime; // Przechowaj początkowy czas respawnu
                respawnTimer.Interval = 1000; // 1 sekunda
                respawnTimer.Tick += (sender, e) =>
                {
                    initialRespawnTime =
                        initialRespawnTime.Subtract(TimeSpan
                            .FromSeconds(1)); // Odjęcie 1 sekundy od początkowego czasu respawnu
                    timeLabel.Text = initialRespawnTime.ToString(); // Aktualizacja etykiety czasu
                    if (initialRespawnTime.TotalSeconds <= 0)
                    {
                        ping.Play();
                        tableLayoutPanel1.Controls.Remove(numberPanel);
                        tableLayoutPanel1.Controls.Remove(leftPanel);
                        tableLayoutPanel1.Controls.Remove(rightPanel);
                        respawnTimer.Stop(); // Zatrzymaj timer, gdy czas respawnu dobiegnie końca
                        timerNumber--;

                        // Aktualizuj numerację pozostałych wpisów w tabeli
                        foreach (Control control in tableLayoutPanel1.Controls)
                            if (control is Panel panel)
                            {
                                var label = panel.Controls.OfType<Label>().FirstOrDefault();
                                if (label != null)
                                {
                                    var currentIndex = tableLayoutPanel1.GetPositionFromControl(panel).Row + 1;
                                    label.Text = currentIndex.ToString();
                                }
                            }

                        // Przesuń wszystkie pozostałe elementy tabeli o jeden krok do tyłu
                        for (var c = 0;
                             c < tableLayoutPanel1.ColumnCount - 2;
                             c += 3) // Zwiększaj o 3, aby przeskakiwać do następnej trójki kolumn
                        for (var r = 0; r < tableLayoutPanel1.RowCount; r++)
                        {
                            var control1 = tableLayoutPanel1.GetControlFromPosition(c, r);
                            var control2 = tableLayoutPanel1.GetControlFromPosition(c + 1, r);
                            var control3 = tableLayoutPanel1.GetControlFromPosition(c + 2, r);

                            if (control1 != null && control2 != null && control3 != null)
                            {
                                var newRow = 0;
                                if (c > 2 && r == 0)
                                {
                                    var newColumn = c - 3;
                                    newRow = tableLayoutPanel1.RowCount - 1;
                                    tableLayoutPanel1.SetCellPosition(control1,
                                        new TableLayoutPanelCellPosition(newColumn, newRow));
                                    tableLayoutPanel1.SetCellPosition(control2,
                                        new TableLayoutPanelCellPosition(newColumn + 1, newRow));
                                    tableLayoutPanel1.SetCellPosition(control3,
                                        new TableLayoutPanelCellPosition(newColumn + 2, newRow));
                                }
                                else
                                {
                                    newRow = r - 1;
                                    if (newRow >= 0)
                                    {
                                        tableLayoutPanel1.SetCellPosition(control1,
                                            new TableLayoutPanelCellPosition(c, newRow));
                                        tableLayoutPanel1.SetCellPosition(control2,
                                            new TableLayoutPanelCellPosition(c + 1, newRow));
                                        tableLayoutPanel1.SetCellPosition(control3,
                                            new TableLayoutPanelCellPosition(c + 2, newRow));
                                    }
                                }
                            }
                        }
                    }
                };
                respawnTimer.Start();

                // Zwiększ numer timera dla kolejnego dodawanego timera
                timerNumber++;

                return; // Przerwij pętlę, gdy już dodano pary paneli
            }
    }

    private void InitializeTableLayoutPanel()
    {
        tableLayoutPanel1.ColumnCount = 12;
        tableLayoutPanel1.RowCount = 5; // Możesz dostosować liczbę wierszy do swoich potrzeb

        // Szerokości kolumn
        var columnWidths = new List<int> { 70, 90, 40 };

        for (var i = 0; i < tableLayoutPanel1.ColumnCount; i++)
        {
            var columnIndex = i % columnWidths.Count; // Pobierz indeks z listy szerokości kolumn

            // Ustaw szerokość kolumny zgodnie z listą szerokości
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, columnWidths[columnIndex]));
        }


        for (var i = 0; i < tableLayoutPanel1.RowCount; i++)
            // Ustaw wysokość wiersza zgodnie z listą wysokości
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
    }

    // Metoda odbierająca pakiet z informacją o bitwie
    public void ReceiveBattlePacket(string packetData)
    {
        // Analizuj otrzymany pakiet i wyodrębnij nazwę moba
        var mobName = ExtractMobName(packetData);
        // Sprawdź czy mob jest na liście championów i uruchom odpowiedni minutnik
        CheckChampionList(mobName);
    }

    // Metoda do ekstrakcji nazwy moba z pakietu bitwy (do zaimplementowania)
    private string ExtractMobName(string packetData)
    {
        // Tutaj implementuj logikę ekstrakcji nazwy moba z pakietu bitwy
        return "SampleMobName";
    }

    private void customButton1_Click(object sender, EventArgs e)
    {
        CheckChampionList("Bibliotekarz");
    }

    // Klasa reprezentująca postać z jej czasem respawnu, obrazkiem i Timerem
    public class CharacterRespawnInfo
    {
        public CharacterRespawnInfo(string name, TimeSpan respawnTime, Image image)
        {
            CharacterName = name;
            RespawnTime = respawnTime;
            CharacterImage = image;
            RespawnTimer = new Timer();
            RemainingTimeLabel = new Label();
            InitializeTimer();
        }

        public string CharacterName { get; set; }
        public TimeSpan RespawnTime { get; set; }
        public Image CharacterImage { get; set; }
        public Timer RespawnTimer { get; set; }
        public Label RemainingTimeLabel { get; set; }

        private void InitializeTimer()
        {
            RespawnTimer.Interval = (int)RespawnTime.TotalMilliseconds;
            RespawnTimer.Tick += (sender, e) =>
            {
                // Wykonaj odpowiednie akcje po upływie czasu respawnu
                ReleaseCell();
            };
        }

        public void StartTimer()
        {
            RespawnTimer.Start();
        }

        public void StopTimer()
        {
            RespawnTimer.Stop();
        }

        private void ReleaseCell()
        {
            // Zwolnij komórkę tabeli
            if (RemainingTimeLabel.Parent is TableLayoutPanel tableLayoutPanel)
            {
                tableLayoutPanel.Controls.Remove(RemainingTimeLabel);
                tableLayoutPanel.Controls.Remove(RemainingTimeLabel.Parent);
            }
        }

        public void UpdateRemainingTimeLabel()
        {
            RemainingTimeLabel.Text =
                RespawnTimer.Enabled ? RespawnTimer.Interval.ToString() : "0"; // Ustawia pozostały czas
        }
    }
}