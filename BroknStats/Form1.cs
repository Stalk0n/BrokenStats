using System;
using System.Windows.Forms;

namespace BroknStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeLogArea();
            laugh();
        }

        private void InitializeLogArea()
        {
            // Ustawienia RichTextBox dla obszaru log�w
            logRichTextBox.ReadOnly = true;
            logRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logRichTextBox.Multiline = true;

            // Ustawienia wygl�du obszaru log�w
            logRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            logRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            logRichTextBox.BorderStyle = BorderStyle.Fixed3D;

            // Dodanie obs�ugi zdarzenia KeyPress dla textBox1
            textBox1.KeyPress += textBox1_KeyPress;
        }

        private void DodajLog(string tekst)
        {
            // Kolor dla daty
            string data = $"{DateTime.Now}: ";
            logRichTextBox.SelectionColor = Color.Blue; // Dostosuj kolor wed�ug potrzeb
            logRichTextBox.AppendText(data);

            // Kolor dla tekstu przesy�anego
            logRichTextBox.SelectionColor = Color.Green; // Dostosuj kolor wed�ug potrzeb
            logRichTextBox.AppendText($"{tekst}{Environment.NewLine}");

            // Przewi� do ostatniego logu
            logRichTextBox.ScrollToCaret();

            // Przywr�� domy�lny kolor dla nast�pnych wpis�w
            logRichTextBox.SelectionColor = logRichTextBox.ForeColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Mo�esz dodatkowe operacje po zmianie tekstu w textBox1
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Mo�esz dodatkowe operacje po klikni�ciu na label1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pobierz tekst z TextBox wej�ciowego
            string tekstDoPrzeslania = textBox1.Text;

            // Dodaj log z wej�cia
            DodajLog(tekstDoPrzeslania);

            // Wyczy�� TextBox wej�ciowy
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mo�esz dodatkowe operacje przy za�adowaniu Form1
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sprawd�, czy naci�ni�to klawisz Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Pobierz tekst z TextBox wej�ciowego
                string tekstDoPrzeslania = textBox1.Text;

                // Dodaj log z wej�cia
                DodajLog(tekstDoPrzeslania);

                // Wyczy�� TextBox wej�ciowy
                textBox1.Clear();

                // Zapobiegaj dalszej obs�udze klawisza Enter
                e.Handled = true;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
