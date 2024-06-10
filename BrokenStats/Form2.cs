using System.ComponentModel;
using BrokenStats.UserControls;

namespace BrokenStats;

public partial class Form2 : Form
{
    public delegate void BattleLogPackedFoundEventHandler(string packetData);

    private UcBattleLog battleLogUc;
    private UcChatLog chatLogUc;

    private LogsContext? dbContext;
    private UcEssenceCalculator essenceCalcUc;
    private bool isMouseDown;
    private Point mouseOffset;
    private UcRespawns respawnsUc;


    public Form2()
    {
        Uruchom_sniffer();
        InitializeComponent();
        var uc = new UcChatLog();
        AddUserControl(uc);
        panel1.MouseDown += Panel1_MouseDown;
        panel1.MouseMove += Panel1_MouseMove;
        panel1.MouseUp += Panel1_MouseUp;
    }


    private void AddUserControl(UserControl userControl)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<UserControl>(AddUserControl), userControl);
        }
        else
        {
            userControl.Dock = DockStyle.Fill;
            foreach (Control control in panelContainer.Controls) control.Visible = false;
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
            var mousePos = MousePosition;
            mousePos.Offset(-mouseOffset.X, -mouseOffset.Y);
            Location = mousePos;
        }
    }

    private void Panel1_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left) isMouseDown = false;
    }

    private void kryptonButton1_Click(object sender, EventArgs e)
    {
        if (chatLogUc == null)
        {
            chatLogUc = new UcChatLog();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Invoke(() => { AddUserControl(chatLogUc); });
            }).Start();
        }
        else
        {
            AddUserControl(chatLogUc);
        }
    }

    private void kryptonButton2_Click(object sender, EventArgs e)
    {
        if (battleLogUc == null)
        {
            battleLogUc = new UcBattleLog();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Invoke(() => { AddUserControl(battleLogUc); });
            }).Start();
        }
        else
        {
            AddUserControl(battleLogUc);
        }
    }

    private void kryptonButton4_Click(object sender, EventArgs e)
    {
        if (essenceCalcUc == null)
        {
            essenceCalcUc = new UcEssenceCalculator();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Invoke(() => { AddUserControl(essenceCalcUc); });
            }).Start();
        }
        else
        {
            AddUserControl(essenceCalcUc);
        }
    }

    private void kryptonButton5_Click(object sender, EventArgs e)
    {
        if (respawnsUc == null)
        {
            respawnsUc = new UcRespawns();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                Invoke(() => { AddUserControl(respawnsUc); });
            }).Start();
        }
        else
        {
            AddUserControl(respawnsUc);
        }
    }


    private void kryptonButton10_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }


    private void kryptonButton8_Click(object sender, EventArgs e)
    {
        Close();
    }


    private static void Uruchom_sniffer()
    {
        var sniffer = new Sniffer();

        new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;

            sniffer.Start();
        }).Start();
    }


    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        dbContext?.Dispose();
        dbContext = null;
    }

    public event BattleLogPackedFoundEventHandler BattleLogPackedFound;


    private void kryptonButton3_Click(object sender, EventArgs e)
    {
        var packet = "Nokbrab\t267\t0\t153\t Stara księga(1)\tRozbitek,Rozbitek";
        Sniffer.ProcessBattleLogPacket(packet);
    }
}