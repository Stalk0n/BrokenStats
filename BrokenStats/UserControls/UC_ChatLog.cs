using Microsoft.EntityFrameworkCore;

namespace BrokenStats.UserControls;

public partial class UcChatLog : UserControl
{
    private LogsContext? dbContext;

    public UcChatLog()
    {
        InitializeComponent();
        Sniffer.ChatLogPacketFound += OnChatLogPackedFound;
    }

    private void OnChatLogPackedFound(string packetData)
    {
        if (InvokeRequired)
        {
            Invoke(() => OnChatLogPackedFound(packetData));
            return;
        }

        if (dbContext != null)
        {
            dbContext.AddChatLogMessage(packetData);
            dbContext.SaveChanges();

            LoadChatLogs();
        }
        else
        {
            MessageBox.Show(@"Brak dostępu do bazy danych.");
        }
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        LoadChatLogs();
    }

    public void SetDbContext(LogsContext context)
    {
        dbContext = context;
        LoadChatLogs();
        RefreshDataGridView();
    }
    private void RefreshDataGridView()
    {
        dbContext.ChatLogNicknames.Load();
        dataGridView1.DataSource = dbContext.ChatLogNicknames.Local.ToBindingList();
    }
    private void LoadChatLogs()
    {
        if (dbContext != null)
        {
            dbContext.Database.EnsureCreated();
            dbContext.ChatLogNicknames.Load();
            dbContext.ChatMessages.Load();
            chatLogNicknameBindingSource.DataSource = dbContext.ChatLogNicknames.Local.ToBindingList();
        }
        else
        {
            MessageBox.Show(@"Brak dostępu do bazy danych.");
        }
    }
}