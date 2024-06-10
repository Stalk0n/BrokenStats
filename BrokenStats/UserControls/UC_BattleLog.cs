using System;
using System.Linq;
using System.Windows.Forms;
using BrokenStats.Tables;
using Microsoft.EntityFrameworkCore;

namespace BrokenStats.UserControls
{
    public partial class UcBattleLog : UserControl
    {
        private LogsContext? dbContext;
        private string selectedNick = string.Empty;

        public UcBattleLog()
        {
            InitializeComponent();
            Sniffer.BattleLogPackedFound += OnBattleLogPacketFound;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void OnBattleLogPacketFound(string packetData)
        {
            if (InvokeRequired)
            {
                Invoke(() => OnBattleLogPacketFound(packetData));
                return;
            }

            if (dbContext != null)
            {
                dbContext.AddBattleLogInstance(packetData);
                dbContext.SaveChanges();

                LoadBattleLogs();
            }
            else
            {
                MessageBox.Show(@"Brak dostępu do bazy danych.");
            }
        }

        public void SetDbContext(LogsContext context)
        {
            dbContext = context;
            LoadBattleLogs();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadBattleLogs();
        }

        private void LoadBattleLogs()
        {
            if (dbContext != null)
            {
                dbContext.Database.EnsureCreated();
                dbContext.BattleLogNicknames.Load();
                dbContext.BattleLogs.Load();

                battleLogNicknameBindingSource.DataSource = dbContext.BattleLogNicknames.Local.ToBindingList();

                if (string.IsNullOrEmpty(selectedNick) && battleLogNicknameBindingSource.Count > 0)
                {
                    selectedNick = ((BattleLogNickname)battleLogNicknameBindingSource[0]).Nick;
                }

                if (!string.IsNullOrEmpty(selectedNick))
                {
                    var filteredLogs = dbContext.BattleLogs.Where(log => log.BattleLogNickname.Nick == selectedNick).ToList();
                    battleLogBindingSource.DataSource = filteredLogs;
                }
                else
                {
                    battleLogBindingSource.DataSource = dbContext.BattleLogs.Local.ToBindingList();
                }
            }
            else
            {
                MessageBox.Show(@"Brak dostępu do bazy danych.");
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedNick = dataGridView1.Rows[e.RowIndex].Cells["nickDataGridViewTextBoxColumn"].Value.ToString();
                LoadBattleLogs();
            }
        }
    }
}
