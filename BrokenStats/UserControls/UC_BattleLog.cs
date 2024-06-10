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
            RefreshDataGridView();

            dbContext?.BattleLogNicknames.Load();
            battleLogNicknameBindingSource.DataSource = dbContext?.BattleLogNicknames.Local.ToBindingList();
        }
        else
        {
            MessageBox.Show(@"Brak dostępu do bazy danych.");
        }
    }

    private void RefreshDataGridView()
    {
        dbContext.BattleLogNicknames.Load();
        dataGridView1.DataSource = dbContext.BattleLogNicknames.Local.ToBindingList();
    }

    public void SetDbContext()
    {
        dbContext = new LogsContext();
        RefreshDataGridView();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        dbContext = new LogsContext();

        dbContext.Database.EnsureCreated();

        dbContext.BattleLogNicknames.Load();
        dbContext.BattleLogs.Load();

        battleLogNicknameBindingSource.DataSource = dbContext.BattleLogNicknames.Local.ToBindingList();
        battleLogBindingSource.DataSource = dbContext.BattleLogs.Local.ToBindingList();
    }
}