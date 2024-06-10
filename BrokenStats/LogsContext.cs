using BrokenStats.Tables;
using Microsoft.EntityFrameworkCore;

namespace BrokenStats;

public class LogsContext : DbContext
{
    public DbSet<ChatMessage> ChatMessages { get; set; }
    public DbSet<ChatLogNickname> ChatLogNicknames { get; set; }

    public DbSet<BattleLog> BattleLogs { get; set; }
    public DbSet<BattleLogNickname> BattleLogNicknames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=MyDB.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }


    public void AddChatLogMessage(string input)
    {
        var firstSpaceIndex = input.IndexOf(' ');

        var nickname = firstSpaceIndex == -1 ? input : input.Substring(0, firstSpaceIndex);
        var messageContent = firstSpaceIndex == -1 ? "" : input.Substring(firstSpaceIndex + 1);

        var existingNickname = ChatLogNicknames.FirstOrDefault(n => n.Nick == nickname);
        if (existingNickname == null)
        {
            existingNickname = new ChatLogNickname { Nick = nickname };
            ChatLogNicknames.Add(existingNickname);
        }

        var newMessage = new ChatMessage
        {
            Message = messageContent,
            ChatLogNickname = existingNickname,
            Data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        ChatMessages.Add(newMessage);
    }

    public void AddBattleLogInstance(string input)
    {
        var parts = input.Split('\t');
        var nick = parts[0];
        var experience = parts[1];
        var psychoExperience = parts[2];
        var gold = parts[3];
        var droppedItems = parts[4];
        var opponents = parts[5];

        var existingNickname = BattleLogNicknames.FirstOrDefault(n => n.Nick == nick);
        if (existingNickname == null)
        {
            existingNickname = new BattleLogNickname { Nick = nick };
            BattleLogNicknames.Add(existingNickname);
        }

        var newBattleLog = new BattleLog
        {
            Experience = Convert.ToDouble(experience),
            PsychoExperience = Convert.ToDouble(psychoExperience),
            Gold = Convert.ToDouble(gold),
            DroppedItems = droppedItems,
            Opponents = opponents,
            BattleLogNickname = existingNickname,
            Data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        BattleLogs.Add(newBattleLog);
    }
}