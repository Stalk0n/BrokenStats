using Microsoft.EntityFrameworkCore;

namespace BrokenStats.UserControls;

public partial class UcBattleLog : UserControl
{
    private LogsContext? dbContext;

    public UcBattleLog()
    {
        InitializeComponent();
        Sniffer.BattleLogPackedFound += OnBattleLogPacketFound;
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
            var parts = packetData.Split('\t');

            dbContext?.SaveChanges();

            dbContext?.BattleLogNicknames.Load();
            battleLogNicknameBindingSource.DataSource = dbContext?.BattleLogNicknames.Local.ToBindingList();
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


        dbContext.BattleLogNicknames.Load();

        battleLogNicknameBindingSource.DataSource = dbContext.BattleLogNicknames.Local.ToBindingList();
    }
}