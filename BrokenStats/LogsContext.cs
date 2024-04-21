using Microsoft.EntityFrameworkCore;

namespace BrokenStats;

public class LogsContext : DbContext
{
    public DbSet<ChatMessage> ChatMessages { get; set; }
    public DbSet<ChatLogNickname> ChatLogNicknames { get; set; }

    public DbSet<BattleLog> BattleLogs { get; set; }
    public DbSet<BattleLogNickname> BattleLogNicknames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=MyDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Funkcja wykonywana na tworzenie modelu danych
    }


    public void AddChatLogMessage(string input)
    {
        int firstSpaceIndex = input.IndexOf(' ');

        string nickname = firstSpaceIndex == -1 ? input : input.Substring(0, firstSpaceIndex);
        string messageContent = firstSpaceIndex == -1 ? "" : input.Substring(firstSpaceIndex + 1);

        ChatLogNickname existingNickname = ChatLogNicknames.FirstOrDefault(n => n.Nick == nickname);
        if (existingNickname == null)
        {
            // Jeśli nick nie istnieje, dodajemy nowego gracza
            existingNickname = new ChatLogNickname { Nick = nickname };
            ChatLogNicknames.Add(existingNickname);
            SaveChanges(); // Zapisujemy zmiany, aby uzyskać ID nowego pseudonimu
        }

        // Dodajemy nową wiadomość dla gracza
        var newMessage = new ChatMessage
        {
            Message = messageContent,
            ChatLogNickname = existingNickname, // Ustawiamy relację z pseudonimem
            Data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        ChatMessages.Add(newMessage);
        SaveChanges();
    }

    public void AddBattleLogInstance(string input)
    {
        string[] parts = input.Split('\t');
        string nick = parts[0];
        string experience = parts[1];
        string psychoExperience = parts[2];
        string gold = parts[3];
        string droppedItems = parts[4];
        string opponents = parts[5];

        BattleLogNickname existingNickname = BattleLogNicknames.FirstOrDefault(n => n.Nick == nick);
        if (existingNickname == null)
        {
            // Jeśli nick nie istnieje, dodajemy nowego gracza
            existingNickname = new BattleLogNickname { Nick = nick };
            BattleLogNicknames.Add(existingNickname);
            SaveChanges(); // Zapisujemy zmiany, aby uzyskać ID nowego pseudonimu
        }

        // Dodajemy nowy wpis w dzienniku bitwy
        var newBattleLog = new BattleLog
        {
            Experience = Convert.ToDouble(experience),
            Psycho_Experience = Convert.ToDouble(psychoExperience),
            Gold = Convert.ToDouble(gold),
            Dropped_items = droppedItems,
            Opponents = opponents,
            BattleLogNickname = existingNickname, // Ustawiamy relację z pseudonimem
            Data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        BattleLogs.Add(newBattleLog);
        SaveChanges();
    }


}