using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BrokenStats
{
    public partial class MainForm : Form
    {
        private LogsContext? _dbContext;

        public MainForm()
        {
            Uruchom_sniffer();
            InitializeComponent();
            Sniffer.ChatLogPacketFound += OnChatLogPackedFound;
            Sniffer.BattleLogPackedFound += OnBattleLogPacketFound;
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

    }
}