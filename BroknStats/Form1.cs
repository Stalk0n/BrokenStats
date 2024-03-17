using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using BroknStats.Classes;



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
        
        private void DodajLog()
        {

            // Pobierz tekst z TextBox wejœciowego
            string unformattedLine = textBox1.Text;

            string[] parts = unformattedLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string itemName = parts[0]; // Pierwsza czêœæ to tekst
            int itemQuantity = 0;
            string droppedFrom = parts[2]; // Pierwsza czêœæ to tekst  ///DODAÆ WYJ¥TEK CO JEZELI WARTOSC W POLU 
            //TEKSTOWYM JEST ZA KROTKA PRZEZ CO WYSKAKUJEMY POZA WARTOSC
            // Spróbuj przekonwertowaæ drug¹ czêœæ na liczbê ca³kowit¹

            try
            {
                if (!(parts.Length > 2 && int.TryParse(parts[1], out itemQuantity)))
                    throw new Exception();

                // Kolor dla daty
                string data = $"{DateTime.Now}: ";
                logRichTextBox.SelectionColor = Color.Blue; // Dostosuj kolor wed³ug potrzeb
                logRichTextBox.AppendText(data);

                // Kolor dla tekstu przesy³anego
                logRichTextBox.SelectionColor = Color.Green; // Dostosuj kolor wed³ug potrzeb
                logRichTextBox.AppendText($"{itemName} ");

                // Kolor dla ilosci
                logRichTextBox.SelectionColor = Color.Red; // Dostosuj kolor wed³ug potrzeb
                logRichTextBox.AppendText($"{itemQuantity} ");

                // Kolor dla entity
                logRichTextBox.SelectionColor = Color.Purple; // Dostosuj kolor wed³ug potrzeb
                logRichTextBox.AppendText($"{droppedFrom}{Environment.NewLine}");



                // Przewiñ do ostatniego logu
                logRichTextBox.ScrollToCaret();

                // Przywróæ domyœlny kolor dla nastêpnych wpisów
                logRichTextBox.SelectionColor = logRichTextBox.ForeColor;


                DataManagement dataManagement = new DataManagement();

                dataManagement.SaveItemData(itemName, itemQuantity);

                /*
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insertItemData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@itemName", tekst));



                cmd.ExecuteNonQuery();
                con.Close();*/



            }
            catch
            {
                MessageBox.Show("Nie udalo sie rozdzielic wejscia na podwartosci");

            }

            textBox1.Clear();



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
            DodajLog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // SprawdŸ, czy naciœniêto klawisz Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                DodajLog();

                // Zapobiegaj dalszej obs³udze klawisza Enter
                e.Handled = true;
            }
        }



        private void tabPage1_Click(object sender, EventArgs e)
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
