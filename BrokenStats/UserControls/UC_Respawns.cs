using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace BrokenStats.UserControls;

public partial class UcRespawns : UserControl
{
    private static readonly string ProjectDirectory =
        Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

    private readonly SoundPlayer ping = new(Path.Combine(ProjectDirectory, "Sounds", "ping.wav"));

    private readonly List<CharacterRespawnInfo> respawnList = new();

    public UcRespawns()
    {
        InitializeComponent();
        InitializeRespawnList();
        InitializeTableLayoutPanel();
        Sniffer.BattleLogPackedFound += ReceiveBattlePacket;

        customButton1.Visible = false;
        customButton2.Visible = false;
    }

    private void InitializeRespawnList()
    {
        Directory.SetCurrentDirectory(ProjectDirectory);
        respawnList.Add(new CharacterRespawnInfo("Kosior", TimeSpan.FromMinutes(25), TimeSpan.FromMinutes(30),
            TimeSpan.FromMinutes(8), "Jaskinia Południowa"));
        respawnList.Add(new CharacterRespawnInfo("Kruczy", TimeSpan.FromMinutes(25), TimeSpan.FromMinutes(30),
            TimeSpan.FromMinutes(8), "Jaskinia Południowa"));
        respawnList.Add(new CharacterRespawnInfo("Ogruch", TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(30),
            TimeSpan.FromMinutes(7), "Podzamcze"));
        respawnList.Add(new CharacterRespawnInfo("Treven", TimeSpan.FromHours(1), new TimeSpan(1, 20, 0),
            TimeSpan.FromMinutes(15), "Wymarła osada"));
        respawnList.Add(new CharacterRespawnInfo("Cybulski", TimeSpan.FromMinutes(35), TimeSpan.FromMinutes(50),
            TimeSpan.FromMinutes(10), "Wymarła osada"));
        respawnList.Add(new CharacterRespawnInfo("Nielichy", TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(28),
            TimeSpan.FromMinutes(8), "Wymarła osada"));
        respawnList.Add(new CharacterRespawnInfo("Popiel", TimeSpan.FromMinutes(30), TimeSpan.FromMinutes(40),
            TimeSpan.FromMinutes(10), "Podzamcze, Zamek Gastelhof"));
        respawnList.Add(new CharacterRespawnInfo("Acerodon", TimeSpan.FromHours(1), new TimeSpan(1, 10, 0),
            TimeSpan.FromMinutes(15),
            "Jaskinie pod Mokradłami, Jaskinie pod Wieżami, Zapomniany Korytarz, Jaszczurzy Cmentarz"));
        respawnList.Add(new CharacterRespawnInfo("Harlair", TimeSpan.FromHours(1), TimeSpan.FromHours(1.25),
            TimeSpan.FromMinutes(15), "Jaskinie pod Granicą, Podzamcze"));
        respawnList.Add(new CharacterRespawnInfo("Król Szczurów", TimeSpan.FromHours(1.5), TimeSpan.FromHours(2),
            TimeSpan.FromMinutes(20), "Jaskinie pod Mokradłami, Jaskinie pod Wieżami"));
        respawnList.Add(new CharacterRespawnInfo("Orthal", TimeSpan.FromMinutes(40), TimeSpan.FromHours(1),
            TimeSpan.FromMinutes(10), "Jaskinie pod Granicą, Podzamcze"));
        respawnList.Add(new CharacterRespawnInfo("Wilhelm Tell", TimeSpan.FromMinutes(45), new TimeSpan(1, 5, 0),
            TimeSpan.FromMinutes(10), "Podzamcze, Zamek Gastelhof"));
        respawnList.Add(new CharacterRespawnInfo("Wilczur", TimeSpan.FromHours(1), new TimeSpan(1, 10, 0),
            TimeSpan.FromMinutes(10), "Wilcza jama"));
        respawnList.Add(new CharacterRespawnInfo("Przybysz", TimeSpan.FromHours(1.5), TimeSpan.FromHours(2),
            TimeSpan.FromMinutes(14), "Wybrzeże"));
        respawnList.Add(new CharacterRespawnInfo("Zębacz", TimeSpan.FromMinutes(40), TimeSpan.FromMinutes(48),
            TimeSpan.FromMinutes(11), "Wybrzeże, Statek, Jaskinie pod Wieżami, Jaskinie pod Mokradłami"));
        respawnList.Add(new CharacterRespawnInfo("Brachyura", TimeSpan.FromMinutes(30), TimeSpan.FromMinutes(45),
            TimeSpan.FromMinutes(12), "Wybrzeże"));
        respawnList.Add(new CharacterRespawnInfo("Tilsai Wędrowny", TimeSpan.FromHours(1), new TimeSpan(1, 10, 0),
            TimeSpan.FromMinutes(17), "Wybrzeże, Statek, Jaskinie pod Wieżami, Jaskinie pod Mokradłami"));
        respawnList.Add(new CharacterRespawnInfo("Karol Kold", TimeSpan.FromMinutes(45), TimeSpan.FromMinutes(57),
            TimeSpan.FromMinutes(12), "Niedźwiedzia jaskinia, Las Koldów"));
        respawnList.Add(new CharacterRespawnInfo("Psychopata", TimeSpan.FromMinutes(50), new TimeSpan(1, 5, 0),
            TimeSpan.FromMinutes(12), "Niedźwiedzia Jaskinia, Las Koldów, Góry Koldów"));
        respawnList.Add(new CharacterRespawnInfo("Krwiopijca", TimeSpan.FromHours(1.5), TimeSpan.FromHours(1.6667),
            TimeSpan.FromMinutes(15), "Niedźwiedzia jaskinia"));
        respawnList.Add(new CharacterRespawnInfo("Zaklinacz Kruków", TimeSpan.FromMinutes(25), TimeSpan.FromMinutes(33),
            new TimeSpan(0, 6, 45), "Las Koldów"));
        respawnList.Add(new CharacterRespawnInfo("Wściekły Grizzly", TimeSpan.FromMinutes(35), TimeSpan.FromMinutes(55),
            TimeSpan.FromMinutes(10), "Niedźwiedzia jaskinia, Las Koldów"));
        respawnList.Add(new CharacterRespawnInfo("Telek", TimeSpan.FromHours(1), TimeSpan.FromHours(1.1),
            TimeSpan.FromMinutes(5), "Las Orków"));
        respawnList.Add(new CharacterRespawnInfo("Rizurul", TimeSpan.FromMinutes(40), TimeSpan.FromMinutes(45),
            TimeSpan.FromMinutes(10), "Las Orków"));
        respawnList.Add(new CharacterRespawnInfo("Zaimm", TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(24),
            TimeSpan.FromMinutes(13), "Las Orków, Namiot wodza orków"));
        respawnList.Add(new CharacterRespawnInfo("Wściekły burkan", TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(30),
            TimeSpan.FromMinutes(10), "Thalia Uniwersytecka"));
        respawnList.Add(new CharacterRespawnInfo("Jesienica", TimeSpan.FromMinutes(35), TimeSpan.FromMinutes(47),
            TimeSpan.FromMinutes(15), "Thalia Uniwersytecka"));
        respawnList.Add(new CharacterRespawnInfo("Dritan żarliwy", TimeSpan.FromHours(1.5), new TimeSpan(1, 50, 0),
            TimeSpan.FromMinutes(15), "Thalia Uniwersytecka"));
        respawnList.Add(new CharacterRespawnInfo("Zimowy Szaman", TimeSpan.FromHours(1), new TimeSpan(1, 10, 0),
            TimeSpan.FromMinutes(21), "Wąwóz Dmorther, Jaskinia na Masywie, Grań, Góry Koldoów"));
        respawnList.Add(new CharacterRespawnInfo("Tygrys Górski", TimeSpan.FromMinutes(25), TimeSpan.FromMinutes(40),
            TimeSpan.FromMinutes(10), "Wąwóz Dmorther, Jaskinia na Masywie, Grań, Płaskowyż Dmorther"));
        respawnList.Add(new CharacterRespawnInfo("Obłąkana Harpia", TimeSpan.FromMinutes(35), TimeSpan.FromMinutes(47),
            TimeSpan.FromMinutes(10), "Wąwóz Dmorther, Płaskowyż Dmorther"));
        respawnList.Add(new CharacterRespawnInfo("Zawieja", TimeSpan.FromMinutes(45), new TimeSpan(1, 5, 0),
            TimeSpan.FromMinutes(18), "Płaskowyż Dmorther"));
        respawnList.Add(new CharacterRespawnInfo("Ragak Maruder", TimeSpan.FromHours(2), TimeSpan.FromHours(2.5),
            TimeSpan.FromMinutes(9), "Wąwóz Dmorther, Grań"));
        respawnList.Add(new CharacterRespawnInfo("Yoko", TimeSpan.FromMinutes(15), TimeSpan.FromMinutes(19),
            TimeSpan.FromMinutes(19), "Chram"));
        respawnList.Add(new CharacterRespawnInfo("Kapłan Śmierci", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1),
            TimeSpan.FromMinutes(15), "Wąwóz Dmorther, Góry Koldów, Grań, Płaskowyż Dmorther"));
        respawnList.Add(new CharacterRespawnInfo("Halmengir", TimeSpan.FromHours(1), TimeSpan.FromHours(1.25),
            TimeSpan.FromHours(1.25), "Opuszczona Wieża, Jaskinia pod wodospadem, Pod mostem"));
        respawnList.Add(new CharacterRespawnInfo("Olm", TimeSpan.FromHours(2), new TimeSpan(2, 20, 0),
            TimeSpan.FromHours(1.25), "Opuszczona Wieża, Jaskinia pod wodospadem, Pod mostem"));
        respawnList.Add(new CharacterRespawnInfo("Troll Zimowy", TimeSpan.FromMinutes(30), TimeSpan.FromMinutes(40),
            TimeSpan.FromMinutes(40), "Zamarznięte Jezioro"));
        respawnList.Add(new CharacterRespawnInfo("Podróżnik", TimeSpan.FromMinutes(20), TimeSpan.FromMinutes(25),
            TimeSpan.FromMinutes(19), "Zamarznięte Jezioro"));
        respawnList.Add(new CharacterRespawnInfo("Koszmar", TimeSpan.FromHours(1), TimeSpan.FromHours(1.25),
            TimeSpan.FromMinutes(20), "Zamarznięte Jezioro"));
        respawnList.Add(new CharacterRespawnInfo("Pacynkarz", TimeSpan.FromMinutes(30), TimeSpan.FromMinutes(40),
            TimeSpan.FromMinutes(14), "Zamarznięte Jezioro"));
        respawnList.Add(new CharacterRespawnInfo("Krwiopij", TimeSpan.FromHours(1), new TimeSpan(1, 40, 0),
            TimeSpan.FromMinutes(25), "Beirn"));
        respawnList.Add(new CharacterRespawnInfo("Wisp", TimeSpan.FromHours(2), TimeSpan.FromHours(3),
            TimeSpan.FromMinutes(30), "Beirn"));
        respawnList.Add(new CharacterRespawnInfo("Żywiciel Jak", TimeSpan.FromHours(1), TimeSpan.FromHours(1.75),
            TimeSpan.FromMinutes(25), "Beirn"));
        respawnList.Add(new CharacterRespawnInfo("Żerca", TimeSpan.FromMinutes(45), TimeSpan.FromHours(1.25),
            TimeSpan.FromMinutes(7), "Lochy"));
        respawnList.Add(new CharacterRespawnInfo("Żywiciel Jeti", TimeSpan.FromHours(1), TimeSpan.FromHours(1.75),
            TimeSpan.FromMinutes(25), "Stok"));
        respawnList.Add(new CharacterRespawnInfo("Gnawk", TimeSpan.FromHours(2), TimeSpan.FromHours(3),
            TimeSpan.FromHours(30).Add(TimeSpan.FromMinutes(45)),
            "Jaskinia pod wodospadem, Jaskinia Olbrzymów, Jaskinia (na północy jeziora)"));
        respawnList.Add(new CharacterRespawnInfo("Mamut", TimeSpan.FromHours(2), TimeSpan.FromHours(3),
            TimeSpan.FromMinutes(40), "Stok"));
        respawnList.Add(new CharacterRespawnInfo("Astronom", TimeSpan.FromHours(6), TimeSpan.FromHours(7),
            TimeSpan.FromMinutes(30), "Lochy"));
        respawnList.Add(new CharacterRespawnInfo("Kowal Lugusa", TimeSpan.FromHours(5).Add(TimeSpan.FromMinutes(31)),
            TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1), "Lochy"));
        respawnList.Add(new CharacterRespawnInfo("Straż Lugusa", TimeSpan.FromHours(5).Add(TimeSpan.FromMinutes(31)),
            TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1), "Lochy"));
        respawnList.Add(new CharacterRespawnInfo("Bibliotekarz", TimeSpan.FromMinutes(17), TimeSpan.FromMinutes(29),
            TimeSpan.FromMinutes(11), "Zamek Gastlehof"));
        respawnList.Add(new CharacterRespawnInfo("Wendigo", TimeSpan.FromHours(2), TimeSpan.FromHours(2.5),
            TimeSpan.FromMinutes(15), "Płaskowyż Dmorther, Wąwóz Dmorther"));
        respawnList.Add(new CharacterRespawnInfo("Jastrzębior", TimeSpan.FromHours(5), TimeSpan.FromHours(7),
            TimeSpan.FromHours(1), "Beirn, Półka Skalna"));
        respawnList.Add(
            new CharacterRespawnInfo("Lugus", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1), TimeSpan.FromHours(48),
                "Lochy"));
    }

    private void CheckChampionList(string mobName)
    {
        var champion = respawnList.FirstOrDefault(character => character.CharacterName == mobName);
        if (champion != null)
        {
            if (champion.RespawnTimer.Enabled)
            {
                champion.ResetTimer();
            }
            else
            {
                champion.ResetPeriods();
                champion.StartTimer();
                AddTimerToLayoutPanel(champion);
            }
        }
    }

    private void AddTimerToLayoutPanel(CharacterRespawnInfo character)
    {
        for (var col = 0; col < tableLayoutPanel1.ColumnCount - 3; col += 4)
        for (var row = 0; row < tableLayoutPanel1.RowCount; row++)
            if (tableLayoutPanel1.GetControlFromPosition(col, row) == null)
            {
                var picturePanel = new Panel();
                picturePanel.Dock = DockStyle.Fill;

                var pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = Image.FromFile(Path.Combine(ProjectDirectory, "Images", character.ImageFileName));
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                picturePanel.Controls.Add(pictureBox);

                var namePanel = new Panel();
                namePanel.Dock = DockStyle.Fill;
                var nameLabel = new Label();
                nameLabel.Text = character.CharacterName;
                nameLabel.Dock = DockStyle.Fill;
                nameLabel.AutoSize = false;
                nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                namePanel.Controls.Add(nameLabel);

                var locationPanel = new Panel();
                locationPanel.Dock = DockStyle.Fill;
                var locationLabel = new Label();
                locationLabel.Text = character.Location;
                locationLabel.Dock = DockStyle.Fill;
                locationLabel.AutoSize = false;
                locationLabel.TextAlign = ContentAlignment.MiddleCenter;
                locationPanel.Controls.Add(locationLabel);

                var timePanel = new Panel();
                timePanel.Dock = DockStyle.Fill;
                var timeLabel = new Label();
                timeLabel.Text = character.DeadPeriod.ToString();
                timeLabel.Dock = DockStyle.Fill;
                timeLabel.AutoSize = false;
                timeLabel.TextAlign = ContentAlignment.MiddleCenter;
                timePanel.Controls.Add(timeLabel);

                tableLayoutPanel1.Controls.Add(picturePanel, col, row);
                tableLayoutPanel1.Controls.Add(namePanel, col + 1, row);
                tableLayoutPanel1.Controls.Add(locationPanel, col + 2, row);
                tableLayoutPanel1.Controls.Add(timePanel, col + 3, row);

                var respawnTimer = new Timer();
                respawnTimer.Enabled = false;
                timeLabel.BackColor = Color.Red;
                respawnTimer.Interval = 1000;
                var pingEvent = false;

                respawnTimer.Tick += (sender, e) =>
                {
                    if (character.DeadPeriod.TotalSeconds <= 0 &&
                        (character.SpawningPeriod - character.OriginalDeadPeriod).TotalSeconds > 0 &&
                        character.LivingPeriod.TotalSeconds > 0)
                    {
                        if (!pingEvent)
                        {
                            ping.Play();
                            pingEvent = true;
                        }

                        timeLabel.BackColor = Color.Yellow;
                        character.SpawningPeriod = character.SpawningPeriod.Subtract(TimeSpan.FromSeconds(1));
                        timeLabel.Text =
                            (character.SpawningPeriod - character.OriginalDeadPeriod).ToString(@"hh\:mm\:ss");
                    }
                    else if (character.DeadPeriod.TotalSeconds > 0 &&
                             (character.SpawningPeriod - character.DeadPeriod).TotalSeconds > 0)
                    {
                        timeLabel.BackColor = Color.Red;
                        character.DeadPeriod = character.DeadPeriod.Subtract(TimeSpan.FromSeconds(1));
                        timeLabel.Text = character.DeadPeriod.ToString(@"hh\:mm\:ss");
                    }
                    else if ((character.SpawningPeriod - character.OriginalDeadPeriod).TotalSeconds <= 0 &&
                             character.DeadPeriod.TotalSeconds <= 0 && character.LivingPeriod.TotalSeconds > 0)
                    {
                        timeLabel.BackColor = Color.Green;
                        character.LivingPeriod = character.LivingPeriod.Subtract(TimeSpan.FromSeconds(1));
                        timeLabel.Text = character.LivingPeriod.ToString(@"hh\:mm\:ss");
                    }
                    else
                    {
                        tableLayoutPanel1.Controls.Remove(picturePanel);
                        tableLayoutPanel1.Controls.Remove(namePanel);
                        tableLayoutPanel1.Controls.Remove(locationPanel);
                        tableLayoutPanel1.Controls.Remove(timePanel);
                        respawnTimer.Enabled = false;
                        character.RespawnTimer.Enabled = false;

                        for (var c = 0; c < tableLayoutPanel1.ColumnCount - 3; c += 4)
                        for (var r = 0; r < tableLayoutPanel1.RowCount; r++)
                        {
                            var control1 = tableLayoutPanel1.GetControlFromPosition(c, r);
                            var control2 = tableLayoutPanel1.GetControlFromPosition(c + 1, r);
                            var control3 = tableLayoutPanel1.GetControlFromPosition(c + 2, r);
                            var control4 = tableLayoutPanel1.GetControlFromPosition(c + 3, r);

                            if (control1 == null || control2 == null || control3 == null || control4 == null) continue;
                            var newRow = 0;
                            if (c > 2 && r == 0)
                            {
                                var newColumn = c - 4;
                                newRow = tableLayoutPanel1.RowCount - 1;
                                tableLayoutPanel1.SetCellPosition(control1,
                                    new TableLayoutPanelCellPosition(newColumn, newRow));
                                tableLayoutPanel1.SetCellPosition(control2,
                                    new TableLayoutPanelCellPosition(newColumn + 1, newRow));
                                tableLayoutPanel1.SetCellPosition(control3,
                                    new TableLayoutPanelCellPosition(newColumn + 2, newRow));
                                tableLayoutPanel1.SetCellPosition(control4,
                                    new TableLayoutPanelCellPosition(newColumn + 3, newRow));
                            }
                            else
                            {
                                newRow = r - 1;
                                if (newRow < 0) continue;
                                tableLayoutPanel1.SetCellPosition(control1,
                                    new TableLayoutPanelCellPosition(c, newRow));
                                tableLayoutPanel1.SetCellPosition(control2,
                                    new TableLayoutPanelCellPosition(c + 1, newRow));
                                tableLayoutPanel1.SetCellPosition(control3,
                                    new TableLayoutPanelCellPosition(c + 2, newRow));
                                tableLayoutPanel1.SetCellPosition(control4,
                                    new TableLayoutPanelCellPosition(c + 3, newRow));
                            }
                        }
                    }
                };

                respawnTimer.Start();
                return;
            }
    }

    private void InitializeTableLayoutPanel()
    {
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.RowCount = 20;

        var columnWidths = new List<int> { 70, 90, 150, 70 };

        for (var i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, columnWidths[i]));

        for (var i = 0; i < tableLayoutPanel1.RowCount; i++)
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73));
    }

    public void ReceiveBattlePacket(string packetData)
    {
        if (InvokeRequired)
        {
            Invoke(() => ReceiveBattlePacket(packetData));
            return;
        }

        var parts = packetData.Split('\t');
        var opponents = parts[5];
        if (opponents.Contains(','))
        {
            var podzielone = opponents.Split(',');
            foreach (var podzial in podzielone) CheckChampionList(podzial);
        }
        else
        {
            CheckChampionList(opponents);
        }
    }

    private void customButton1_Click(object sender, EventArgs e)
    {
        CheckChampionList("Treven");
    }

    private void customButton2_Click(object sender, EventArgs e)
    {
        CheckChampionList("Przybysz");
    }

    public class CharacterRespawnInfo
    {
        public CharacterRespawnInfo(string name, TimeSpan deadPeriod, TimeSpan spawningPeriod, TimeSpan livingPeriod,
            string location)
        {
            CharacterName = name;
            DeadPeriod = deadPeriod;
            SpawningPeriod = spawningPeriod;
            LivingPeriod = livingPeriod;
            Location = location;

            OriginalDeadPeriod = deadPeriod;
            OriginalSpawningPeriod = spawningPeriod;
            OriginalLivingPeriod = livingPeriod;

            ImageFileName = name + ".png";
            RespawnTimer = new Timer();
            RemainingTimeLabel = new Label();
            InitializeTimer();
        }

        public string CharacterName { get; set; }
        public TimeSpan DeadPeriod { get; set; }
        public TimeSpan SpawningPeriod { get; set; }
        public TimeSpan LivingPeriod { get; set; }
        public string Location { get; set; }

        public TimeSpan OriginalDeadPeriod { get; }
        public TimeSpan OriginalSpawningPeriod { get; }
        public TimeSpan OriginalLivingPeriod { get; }

        public string ImageFileName { get; set; }
        public Timer RespawnTimer { get; }
        public Label RemainingTimeLabel { get; }

        private void InitializeTimer()
        {
            RespawnTimer.Interval = (int)DeadPeriod.TotalMilliseconds;
            RespawnTimer.Tick += (sender, e) => { ReleaseCell(); };
        }

        public void StartTimer()
        {
            RespawnTimer.Start();
        }

        public void ResetPeriods()
        {
            DeadPeriod = OriginalDeadPeriod;
            SpawningPeriod = OriginalSpawningPeriod;
            LivingPeriod = OriginalLivingPeriod;
        }

        public void ResetTimer()
        {
            RespawnTimer.Stop();
            ResetPeriods();
            InitializeTimer();
            RespawnTimer.Start();
        }

        private void ReleaseCell()
        {
            if (RemainingTimeLabel.Parent is TableLayoutPanel tableLayoutPanel)
            {
                tableLayoutPanel.Controls.Remove(RemainingTimeLabel);
                tableLayoutPanel.Controls.Remove(RemainingTimeLabel.Parent);
            }
        }
    }
}