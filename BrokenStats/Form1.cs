namespace BrokenStats;

using System;
using System.Windows.Forms;
using System.Data.SQLite;

public partial class Form1 : Form
{
    public Form1()
    {
        Uruchom_sniffer();
        InitializeComponent();
        InitializeLogArea();
        Sniffer.PacketFound += OnPacketFound;
    }

    private void OnPacketFound(string packetData)
    {
        HandlePacketFound(packetData, this);
    }

    static void HandlePacketFound(string packetData, Form1 formInstance)
    {
        // Console.WriteLine("Received packet data: " + packetData);
        SQLiteDatabaseHandler dbHandler = new SQLiteDatabaseHandler("MyDB.db");
        dbHandler.InsertData(packetData);
        dbHandler.CloseConnection();

        formInstance.bindingSource1.DataSource = dbHandler.GetData();
        formInstance.bindingSource1.ResetBindings(false);
        formInstance.dataGridView1.Refresh();
    }

    private void InitializeLogArea()
    {
        // Ustawienia RichTextBox dla obszaru logów
        logRichTextBox.ReadOnly = true;
        logRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
        logRichTextBox.Multiline = true;

        // Ustawienia wyglądu obszaru logów
        logRichTextBox.BackColor = System.Drawing.SystemColors.Window;
        logRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
        logRichTextBox.BorderStyle = BorderStyle.Fixed3D;
    }

    private void DodajLog(string tekst)
    {
        // Kolor dla daty
        string data = $"{DateTime.Now}: ";
        logRichTextBox.SelectionColor = Color.Blue; // Dostosuj kolor według potrzeb
        logRichTextBox.AppendText(data);

        // Kolor dla tekstu przesyłanego
        logRichTextBox.SelectionColor = Color.Green; // Dostosuj kolor według potrzeb
        logRichTextBox.AppendText($"{tekst}{Environment.NewLine}");

        // Przewiń do ostatniego logu
        logRichTextBox.ScrollToCaret();

        // Przywróć domyślny kolor dla następnych wpisów
        logRichTextBox.SelectionColor = logRichTextBox.ForeColor;

        SQLiteDatabaseHandler dbHandler = new SQLiteDatabaseHandler("MyDB.db");
        dbHandler.InsertData(tekst);
        dbHandler.CloseConnection();

        bindingSource1.DataSource = dbHandler.GetData();
        bindingSource1.ResetBindings(false);
        dataGridView1.Refresh();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }


    private void Form1_Load(object sender, EventArgs e)
    {
        SQLiteDatabaseHandler dbHandler = new SQLiteDatabaseHandler("MyDB.db");
        dbHandler.InitializeDatabase();

        // Przypisz dane z bazy do DataGridView przez BindingSource
        bindingSource1.DataSource = dbHandler.GetData();

        // Ustaw �r�d�o danych dla DataGridView
        dataGridView1.DataSource = bindingSource1;
    }


    private void tabPage1_Click(object sender, EventArgs e)
    {
    }

    private void tabPage1_Click_1(object sender, EventArgs e)
    {
    }

    private void Uruchom_sniffer()
    {
        Sniffer sniffer = new Sniffer();

        new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;

            sniffer.Start();
        }).Start();
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