using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BrokenStats;

public class LogsContext : DbContext
{
    public DbSet<Message> Messages { get; set; }
    public DbSet<Nickname> Nicknames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=MyDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //Funkcja wykonywana na tworzenie modelu danych

    }


    public void AddMessageFromInput(string input)
    {
        // Rozdzielanie ciągu na nick gracza i wiadomość
        string[] parts = input.Split(';');
        if (parts.Length != 2)
        {
            Console.WriteLine("Nieprawidłowy format danych.");
            return;
        }

        string nickname = parts[0];
        string messageContent = parts[1];

        // Sprawdzenie, czy nick gracza istnieje w tabeli Nicknames
        var existingNickname = Nicknames.FirstOrDefault(n => n.Nick == nickname);
        if (existingNickname == null)
        {
            // Jeśli nick nie istnieje, dodajemy nowego gracza
            existingNickname = new Nickname { Nick = nickname };
            Nicknames.Add(existingNickname);
            SaveChanges();
        }

        // Dodanie nowej wiadomości dla gracza
        var newMessage = new Message
        {
            message = messageContent,
            NicknameId = existingNickname.NicknameId,
            Data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        };
        Messages.Add(newMessage);
        SaveChanges();
    }


 




}