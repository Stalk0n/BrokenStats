using System.Windows.Forms;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System.Net.NetworkInformation;
using System.Linq;

public partial class NetworkInterfaceSelectorForm : Form
{
    public PacketDevice SelectedDevice { get; private set; }

    public NetworkInterfaceSelectorForm()
    {
        InitializeComponent();
        LoadNetworkInterfaces();
        buttonOk.Click += ButtonOk_Click;
    }

    private void LoadNetworkInterfaces()
    {
        IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
        foreach (var device in allDevices)
        {
            string desc = device.Description ?? "Brak opisu";
            string ip = device.Addresses.FirstOrDefault(a => a.Address.Family == SocketAddressFamily.Internet)?.Address.ToString() ?? "";
            string display = string.IsNullOrEmpty(ip) ? desc : $"{desc} ({ip})";
            comboBoxInterfaces.Items.Add(new ComboBoxItem { Device = device, Description = display });
        }
        if (comboBoxInterfaces.Items.Count > 0)
            comboBoxInterfaces.SelectedIndex = 0;
    }

    private void ButtonOk_Click(object sender, System.EventArgs e)
    {
        if (comboBoxInterfaces.SelectedItem is ComboBoxItem item)
        {
            SelectedDevice = item.Device;
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Wybierz interfejs sieciowy.");
        }
    }

    private class ComboBoxItem
    {
        public LivePacketDevice Device { get; set; }
        public string Description { get; set; }
        public override string ToString() => Description;
    }
}