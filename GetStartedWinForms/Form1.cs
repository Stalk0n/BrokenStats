using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BrokenStats
{
    public partial class MainForm : Form
    {
        private ProductsContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ProductsContext();

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

        private void Button_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewNicknames.Refresh();
            this.dataGridViewMessages.Refresh();
        }

        private void dataGridViewNicknames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dbContext != null)
            {
                dbContext.AddMessageFromInput("trzy", "2");
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
    }
}