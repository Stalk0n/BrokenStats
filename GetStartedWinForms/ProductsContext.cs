using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BrokenStats;

public class ProductsContext : DbContext
{
    public DbSet<Message> Messages { get; set; }
    public DbSet<Nickname> Nicknames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=MyDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nickname>().HasData(
            new Nickname { NicknameId = 1, Nick = "Cheese" },
            new Nickname { NicknameId = 2, Nick = "Meat" },
            new Nickname { NicknameId = 3, Nick = "Fish" },
            new Nickname { NicknameId = 4, Nick = "Bread" });

        modelBuilder.Entity<Message>().HasData(
            new Message { MessageId = 1, NicknameId = 1, Data="2024.1.1", message = "Cheddar" },
            new Message { MessageId = 2, NicknameId = 1, message = "Brie" },
            new Message { MessageId = 3, NicknameId = 1, message = "Stilton" },
            new Message { MessageId = 4, NicknameId = 1, message = "Cheshire" },
            new Message { MessageId = 5, NicknameId = 1, message = "Swiss" },
            new Message { MessageId = 6, NicknameId = 1, message = "Gruyere" },
            new Message { MessageId = 7, NicknameId = 1, message = "Colby" },
            new Message { MessageId = 8, NicknameId = 1, message = "Mozzela" },
            new Message { MessageId = 9, NicknameId = 1, message = "Ricotta" },
            new Message { MessageId = 10, NicknameId = 1, message = "Parmesan" },
            new Message { MessageId = 11, NicknameId = 2, message = "Ham" },
            new Message { MessageId = 12, NicknameId = 2, message = "Beef" },
            new Message { MessageId = 13, NicknameId = 2, message = "Chicken" },
            new Message { MessageId = 14, NicknameId = 2, message = "Turkey" },
            new Message { MessageId = 15, NicknameId = 2, message = "Prosciutto" },
            new Message { MessageId = 16, NicknameId = 2, message = "Bacon" },
            new Message { MessageId = 17, NicknameId = 2, message = "Mutton" },
            new Message { MessageId = 18, NicknameId = 2, message = "Pastrami" },
            new Message { MessageId = 19, NicknameId = 2, message = "Hazlet" },
            new Message { MessageId = 20, NicknameId = 2, message = "Salami" },
            new Message { MessageId = 21, NicknameId = 3, message = "Salmon" },
            new Message { MessageId = 22, NicknameId = 3, message = "Tuna" },
            new Message { MessageId = 23, NicknameId = 3, message = "Mackerel" },
            new Message { MessageId = 24, NicknameId = 4, message = "Rye" },
            new Message { MessageId = 25, NicknameId = 4, message = "Wheat" },
            new Message { MessageId = 26, NicknameId = 4, message = "Brioche" },
            new Message { MessageId = 27, NicknameId = 4, message = "Naan" },
            new Message { MessageId = 28, NicknameId = 4, message = "Focaccia" },
            new Message { MessageId = 29, NicknameId = 4, message = "Malted" },
            new Message { MessageId = 30, NicknameId = 4, message = "Sourdough" },
            new Message { MessageId = 31, NicknameId = 4, message = "Corn" },
            new Message { MessageId = 32, NicknameId = 4, message = "White" },
            new Message { MessageId = 33, NicknameId = 4, message = "Soda" });
    }


    public void AddMessageFromInput(string newMessage, string nicknameId)
    {
        if (int.TryParse(nicknameId, out int nicknameIdValue))
        {
            DateTime now = DateTime.Now;
            string dateString = now.ToString("yyyy-MM-dd HH:mm:ss");


            var message = new Message { message = newMessage, NicknameId = nicknameIdValue, Data=dateString };
            Messages.Add(message);
            SaveChanges();
        }
        else
        {
            Console.WriteLine("Nieprawidłowy identyfikator kategorii.");
        }




    }


    public void WypiszWiadomosc()
    {
        MessageBox.Show("elo");
    }


}