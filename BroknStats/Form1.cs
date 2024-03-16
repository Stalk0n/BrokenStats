using System;
using System.Windows.Forms;
using System.Data.SQLite;


namespace BroknStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLogArea();



        }

        private void InitializeLogArea()
        {
            // Ustawienia RichTextBox dla obszaru logów
            logRichTextBox.ReadOnly = true;
            logRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logRichTextBox.Multiline = true;

            // Ustawienia wygl¹du obszaru logów
            logRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            logRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            logRichTextBox.BorderStyle = BorderStyle.Fixed3D;

            // Dodanie obs³ugi zdarzenia KeyPress dla textBox1
            textBox1.KeyPress += textBox1_KeyPress;
        }
        XD
        private void DodajLog(string tekst)
        {
            // Kolor dla daty
            string data = $"{DateTime.Now}: ";
            logRichTextBox.SelectionColor = Color.Blue; // Dostosuj kolor wed³ug potrzeb
            logRichTextBox.AppendText(data);

            // Kolor dla tekstu przesy³anego
            logRichTextBox.SelectionColor = Color.Green; // Dostosuj kolor wed³ug potrzeb
            logRichTextBox.AppendText($"{tekst}{Environment.NewLine}");

            // Przewiñ do ostatniego logu
            logRichTextBox.ScrollToCaret();

            // Przywróæ domyœlny kolor dla nastêpnych wpisów
            logRichTextBox.SelectionColor = logRichTextBox.ForeColor;

            SQLiteDatabaseHandler dbHandler = new SQLiteDatabaseHandler("MyDB.db");
            dbHandler.InsertData(tekst);
            dbHandler.CloseConnection();

            bindingSource1.DataSource = dbHandler.GetData();
            bindingSource1.ResetBindings(false); // Odœwie¿ dane w BindingSource
            dataGridView1.Refresh(); // Odœwie¿ DataGridView
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Mo¿esz dodatkowe operacje po zmianie tekstu w textBox1
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Mo¿esz dodatkowe operacje po klikniêciu na label1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pobierz tekst z TextBox wejœciowego
            string tekstDoPrzeslania = textBox1.Text;

            // Dodaj log z wejœcia
            DodajLog(tekstDoPrzeslania);

            // Wyczyœæ TextBox wejœciowy
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteDatabaseHandler dbHandler = new SQLiteDatabaseHandler("MyDB.db");
            dbHandler.InitializeDatabase();

            // Przypisz dane z bazy do DataGridView przez BindingSource
            bindingSource1.DataSource = dbHandler.GetData();

            // Ustaw Ÿród³o danych dla DataGridView
            dataGridView1.DataSource = bindingSource1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // SprawdŸ, czy naciœniêto klawisz Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Pobierz tekst z TextBox wejœciowego
                string tekstDoPrzeslania = textBox1.Text;

                // Dodaj log z wejœcia
                DodajLog(tekstDoPrzeslania);

                // Wyczyœæ TextBox wejœciowy
                textBox1.Clear();

                // Zapobiegaj dalszej obs³udze klawisza Enter
                e.Handled = true;
            }
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sQLiteDatabaseHandlerBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
