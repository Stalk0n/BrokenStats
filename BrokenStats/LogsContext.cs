using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BrokenStats;

public class LogsContext : DbContext
{
    public DbSet<Messages> Messages { get; set; }
    public DbSet<Nickname> Nicknames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=MyDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Funkcja wykonywana na tworzenie modelu danych

    }


    public void AddMessageFromInput(string input)
    {

        int firstSpaceIndex = input.IndexOf(' ');
        
        string nickname = firstSpaceIndex == -1 ? input : input.Substring(0, firstSpaceIndex);
        string messageContent = firstSpaceIndex == -1 ? "" : input.Substring(firstSpaceIndex + 1);
        
        var existingNickname = Nicknames.FirstOrDefault(n => n.Nick == nickname);
        if (existingNickname == null)
        {
            // Jeśli nick nie istnieje, dodajemy nowego gracza
            existingNickname = new Nickname { Nick = nickname };
            Nicknames.Add(existingNickname);
            SaveChanges();
        }

        // Dodanie nowej wiadomości dla gracza
        var newMessage = new Messages
        {
            Message = messageContent,
            NicknameId = existingNickname.NicknameId,
            Data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        Messages.Add(newMessage);
        SaveChanges();
    }


 




}