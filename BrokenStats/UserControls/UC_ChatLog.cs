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

            dbContext.ChatLogNicknames.Load();
            chatLogNicknameBindingSource.DataSource = dbContext.ChatLogNicknames.Local.ToBindingList();
        }
        else
        {
            MessageBox.Show(@"Brak dostępu do bazy danych.");
        }
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        dbContext = new LogsContext();

        // Uncomment the line below to start fresh with a new database.
        // dbContext.Database.EnsureDeleted(); 
        // dbContext.Database.EnsureCreated();

        dbContext.ChatLogNicknames.Load();

        chatLogNicknameBindingSource.DataSource = dbContext.ChatLogNicknames.Local.ToBindingList();
    }
}