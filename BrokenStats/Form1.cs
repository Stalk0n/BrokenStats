namespace BrokenStats;

using System;
using System.Windows.Forms;

public partial class Form1
{
    public Form1()
    {
        Uruchom_sniffer();
        InitializeComponent();
        Sniffer.PacketFound += OnPacketFound;
    }

    private void OnPacketFound(string packetData)
    {
        HandlePacketFound(packetData, this);
    }

    static void HandlePacketFound(string packetData, Form1 formInstance)
    {
        // Console.WriteLine("Received packet data: " + packetData);
        SqLiteDatabaseHandler dbHandler = new SqLiteDatabaseHandler("MyDB.db");
        dbHandler.InsertData(packetData);
        dbHandler.CloseConnection();

        formInstance.bindingSource1.DataSource = dbHandler.GetData();
        formInstance.bindingSource1.ResetBindings(false);
        formInstance.dataGridView1.Refresh();
    }


    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SqLiteDatabaseHandler dbHandler = new SqLiteDatabaseHandler("MyDB.db");
        dbHandler.InitializeDatabase();

        bindingSource1.DataSource = dbHandler.GetData();

        dataGridView1.DataSource = bindingSource1;
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