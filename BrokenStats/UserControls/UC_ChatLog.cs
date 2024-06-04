using BrokenStats.Tables;
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
    public partial class UC_ChatLog : UserControl
    {
        private LogsContext? _dbContext;
        public UC_ChatLog()
        {
            InitializeComponent();
            Sniffer.ChatLogPacketFound += OnChatLogPackedFound;
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

        private void button2_Click(object sender, EventArgs e)
        {
              if (_dbContext != null)
              {
                  _dbContext.AddChatLogMessage("Mateusz PIWOcvzsfvbdfbdfbzdfbzdfbzdbzxcvbxbcxcbzxbzxcbzxcbzxc zxcb zxb zxcb xczbxcbzxcb zxcb zxcb  xcb");
                  _dbContext.SaveChanges();

                  _dbContext.ChatLogNicknames.Load();
                  chatLogNicknameBindingSource.DataSource = _dbContext.ChatLogNicknames.Local.ToBindingList();
              }
              else
              {
                  MessageBox.Show("Brak dostêpu do bazy danych.");
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

            chatLogNicknameBindingSource.DataSource = _dbContext.ChatLogNicknames.Local.ToBindingList();

        }
    }
}
