using BrokenStats.UserControls;
using System.ComponentModel;


namespace BrokenStats
{
    public partial class Form2 : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        private LogsContext? _dbContext;

        private UC_ChatLog chatLogUC;
        private UC_BattleLog battleLogUC;
        private UC_EssenceCalculator essenceCalcUC;
        private UC_Respawns respawnsUC;


        public Form2()
        {
            Uruchom_sniffer();
            InitializeComponent();
            UC_ChatLog uc = new UC_ChatLog();
            addUserControl(uc);
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;
        }



        private void addUserControl(UserControl userControl)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<UserControl>(addUserControl), userControl);
            }
            else
            {
                userControl.Dock = DockStyle.Fill;
                foreach (Control control in panelContainer.Controls)
                {
                    control.Visible = false;
                }
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(userControl);
                userControl.Visible = true;
            }
        }



        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(e.X, e.Y);
                isMouseDown = true;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(-mouseOffset.X, -mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            UC_ChatLog uc = new UC_ChatLog();
            addUserControl(uc);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            UC_BattleLog uc = new UC_BattleLog();
            addUserControl(uc);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            if (essenceCalcUC == null)
            {
                essenceCalcUC = new UC_EssenceCalculator();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Invoke((Action)(() =>
                    {
                        addUserControl(essenceCalcUC);
                    }));
                }).Start();
            }
            else
            {
                addUserControl(essenceCalcUC);
            }
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            if (respawnsUC == null)
            {
                respawnsUC = new UC_Respawns();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Invoke((Action)(() =>
                    {
                        addUserControl(respawnsUC);
                    }));
                }).Start();
            }
            else
            {
                addUserControl(respawnsUC);
            }
        }


        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            this.Close();
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


        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

    }
}
