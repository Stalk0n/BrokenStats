using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrokenStats.UserControls
{
    public partial class UC_BattleLog : UserControl
    {
        private LogsContext? _dbContext;

        public UC_BattleLog()
        {
            InitializeComponent();
            Sniffer.BattleLogPackedFound += OnBattleLogPacketFound;
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



            _dbContext.BattleLogNicknames.Load();

            battleLogNicknameBindingSource.DataSource = _dbContext.BattleLogNicknames.Local.ToBindingList();

        }
    }
}
