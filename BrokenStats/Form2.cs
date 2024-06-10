using System.ComponentModel;
using BrokenStats.UserControls;

namespace BrokenStats;

public partial class Form2 : Form
{
    public delegate void BattleLogPackedFoundEventHandler(string packetData);

    private readonly UcBattleLog battleLogUc;
    private readonly UcChatLog chatLogUc;
    private readonly UcEssenceCalculator essenceCalcUc;
    private readonly UcRespawns respawnsUc;
    private LogsContext? dbContext;
    private bool isMouseDown;
    private Point mouseOffset;

    public Form2()
    {
        InitializeComponent();
        UruchomSniffer();

        dbContext = new LogsContext();

        chatLogUc = new UcChatLog();
        battleLogUc = new UcBattleLog();
        essenceCalcUc = new UcEssenceCalculator();
        respawnsUc = new UcRespawns();

        InitializeUserControls();

        AddUserControl(chatLogUc);
        AddUserControl(battleLogUc);
        AddUserControl(essenceCalcUc);
        AddUserControl(respawnsUc);

        ShowUserControl(chatLogUc);

        panel1.MouseDown += Panel1_MouseDown;
        panel1.MouseMove += Panel1_MouseMove;
        panel1.MouseUp += Panel1_MouseUp;

        kryptonButton3.Visible = false;
        label1.Visible = false;
        label2.Visible = false;
    }

    private void InitializeUserControls()
    {
        if (dbContext != null)
        {
            battleLogUc.SetDbContext(dbContext);
            chatLogUc.SetDbContext(dbContext);
        }
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
            userControl.Visible = false;
            panelContainer.Controls.Add(userControl);
        }
    }

    private void ShowUserControl(UserControl userControl)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<UserControl>(ShowUserControl), userControl);
        }
        else
        {
            foreach (Control control in panelContainer.Controls) control.Visible = false;
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
        ShowUserControl(chatLogUc);
    }

    private void kryptonButton2_Click(object sender, EventArgs e)
    {
        ShowUserControl(battleLogUc);
    }

    private void kryptonButton4_Click(object sender, EventArgs e)
    {
        ShowUserControl(essenceCalcUc);
    }

    private void kryptonButton5_Click(object sender, EventArgs e)
    {
        ShowUserControl(respawnsUc);
    }

    private void kryptonButton10_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void kryptonButton8_Click(object sender, EventArgs e)
    {
        Close();
    }

    private static void UruchomSniffer()
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

    private void kryptonButton3_Click(object sender, EventArgs e)
    {
        var packet = "Nokbrab\t267\t0\t153\t Stara księga(1)\tBrachyura,Krabostwór,Krabostwór";
        Sniffer.ProcessBattleLogPacket(packet);
    }
}