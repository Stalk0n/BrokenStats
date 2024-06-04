using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace BrokenStats.UserControls;

public partial class UC_Respawns : UserControl
{
    private static readonly string projectDirectory =
        Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));

    private readonly SoundPlayer ping = new(Path.Combine(projectDirectory, "Sounds", "ping.wav"));

    private readonly List<CharacterRespawnInfo> respawnList = new();



    public UC_Respawns()
    {
        InitializeComponent();
        InitializeRespawnList();
        InitializeTableLayoutPanel();
        Sniffer.BattleLogPackedFound += ReceiveBattlePacket;
    }


    private void InitializeRespawnList()
    {
        Directory.SetCurrentDirectory(projectDirectory);
        var imagePath = Path.Combine(projectDirectory, "Images");
        respawnList.Add(new CharacterRespawnInfo("Bibliotekarz", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(3),
            TimeSpan.FromSeconds(2)));
        respawnList.Add(new CharacterRespawnInfo("Lugus", TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(5),
            TimeSpan.FromSeconds(3)));
        respawnList.Add(new CharacterRespawnInfo("Wilk", TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(15),
            TimeSpan.FromSeconds(6)));
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
        for (var col = 0; col < tableLayoutPanel1.ColumnCount - 2; col += 3)
        {
            for (var row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                if (tableLayoutPanel1.GetControlFromPosition(col, row) == null)
                {

                    var picturePanel = new Panel();
                    picturePanel.Dock = DockStyle.Fill;

                    var pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.Image = Image.FromFile(Path.Combine(projectDirectory, "Images", character.ImageFileName));
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
                    tableLayoutPanel1.Controls.Add(timePanel, col + 2, row);

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
                            timeLabel.Text = (character.SpawningPeriod - character.OriginalDeadPeriod).ToString(@"hh\:mm\:ss");


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
                            tableLayoutPanel1.Controls.Remove(timePanel);
                            respawnTimer.Enabled = false;
                            character.RespawnTimer.Enabled = false;


                            foreach (Control control in tableLayoutPanel1.Controls)
                            {
                                if (control is not Panel panel) continue;
                                var label = panel.Controls.OfType<Label>().FirstOrDefault();
                                if (label == null) continue;
                                var currentIndex = tableLayoutPanel1.GetPositionFromControl(panel).Row + 1;
                                // label.Text = currentIndex.ToString();
                            }

                            for (var c = 0; c < tableLayoutPanel1.ColumnCount - 2; c += 3)
                            {
                                for (var r = 0; r < tableLayoutPanel1.RowCount; r++)
                                {
                                    var control1 = tableLayoutPanel1.GetControlFromPosition(c, r);
                                    var control2 = tableLayoutPanel1.GetControlFromPosition(c + 1, r);
                                    var control3 = tableLayoutPanel1.GetControlFromPosition(c + 2, r);

                                    if (control1 == null || control2 == null || control3 == null) continue;
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
                                        if (newRow < 0) continue;
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
                    };

                    respawnTimer.Start();
                    return;
                }
            }
        }
    }



    private void InitializeTableLayoutPanel()
    {
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.RowCount = 20;

        var columnWidths = new List<int> { 70, 90, 70 };

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


 

    public class CharacterRespawnInfo
    {
        public CharacterRespawnInfo(string name, TimeSpan deadPeriod, TimeSpan spawningPeriod, TimeSpan livingPeriod)
        {
            CharacterName = name;
            DeadPeriod = deadPeriod;
            SpawningPeriod = spawningPeriod;
            LivingPeriod = livingPeriod;

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

    private void customButton1_Click(object sender, EventArgs e)
    {
        CheckChampionList("Bibliotekarz");
    }
    private void customButton2_Click(object sender, EventArgs e)
    {
        CheckChampionList("Lugus");
    }
}