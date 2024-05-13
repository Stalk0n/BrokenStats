using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrokenStats.UserControls;

namespace BrokenStats
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UC_ChatLog uc = new UC_ChatLog();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_ChatLog uc = new UC_ChatLog();
            addUserControl(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_BattleLog uc = new UC_BattleLog();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_EssenceCalculator uc = new UC_EssenceCalculator();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_BattleStatistics uc = new UC_BattleStatistics();
            addUserControl(uc);
        }
    }
}
