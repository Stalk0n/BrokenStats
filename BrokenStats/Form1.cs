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
            if (_dbContext != null)
            {
                _dbContext.AddMessageFromInput(packetData);
                _dbContext.SaveChanges();
                
                _dbContext.Nicknames.Load();
                categoryBindingSource.DataSource = _dbContext.Nicknames.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show("Brak dostêpu do bazy danych.");
            }

        }

        private void OnBattleLogPacketFound(string packet)
        {
            
        }
        

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _dbContext = new LogsContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();

            _dbContext.Nicknames.Load();

            categoryBindingSource.DataSource = _dbContext.Nicknames.Local.ToBindingList();
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
                var nickname = (Nickname)dataGridViewNicknames.CurrentRow!.DataBoundItem;

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
                _dbContext.AddMessageFromInput("Mateusz PIWO");
                _dbContext.SaveChanges();

                // Odœwie¿anie danych w formularzu
                _dbContext.Nicknames.Load();
                categoryBindingSource.DataSource = _dbContext.Nicknames.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show("Brak dostêpu do bazy danych.");
            }
        }
    }
}