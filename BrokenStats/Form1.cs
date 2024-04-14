using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace BrokenStats
{
    public partial class MainForm : Form
    {
        private LogsContext? dbContext;

        public MainForm()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new LogsContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Nicknames.Load();

            this.categoryBindingSource.DataSource = dbContext.Nicknames.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewNicknames_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var nickname = (Nickname)this.dataGridViewNicknames.CurrentRow.DataBoundItem;

                if (nickname != null)
                {
                    this.dbContext.Entry(nickname).Collection(e => e.Messages).Load();
                }
            }
        }


        private void dataGridViewNicknames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dbContext != null)
            {
                dbContext.AddMessageFromInput("Kamil;PIWO");
                dbContext.SaveChanges();

                // Odœwie¿anie danych w formularzu
                this.dbContext.Nicknames.Load();
                this.categoryBindingSource.DataSource = dbContext.Nicknames.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show("Brak dostêpu do bazy danych.");
            }

        }



        //mozna skasowac
        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start https://cdn.hejto.pl/uploads/posts/images/250x250/767493e0482dcfbcc8df05e8f6694ad1.gif",
                    CreateNoWindow = true
                });
                MessageBox.Show("Mówi³em nie klikaj");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d podczas otwierania strony internetowej: " + ex.Message);
            }
        }
    }
}