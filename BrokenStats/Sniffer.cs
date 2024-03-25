using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace BrokenStats
{
    class Sniffer
    {
        public delegate void PacketFoundEventHandler(string packetData);

        public static event PacketFoundEventHandler PacketFound;

        public void Start()
        {
            // Retrieve the device list from the local machine
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

            if (allDevices.Count == 0)
            {
                Console.WriteLine("No interfaces found! Make sure WinPcap is installed.");
                return;
            }

            // Print the list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                Console.Write((i + 1) + ". " + device.Name);
                if (device.Description != null)
                    Console.WriteLine(" (" + device.Description + ")");
                else
                    Console.WriteLine(" (No description available)");
            }

            int deviceIndex = 1;
            // do
            // {
            //     Console.WriteLine("Enter the interface number (1-" + allDevices.Count + "):");
            //     string deviceIndexString = Console.ReadLine();
            //     if (!int.TryParse(deviceIndexString, out deviceIndex) ||
            //         deviceIndex < 1 || deviceIndex > allDevices.Count)
            //     {
            //         deviceIndex = 0;
            //     }
            // } while (deviceIndex == 0);

            // Take the selected adapter
            PacketDevice selectedDevice = allDevices[deviceIndex - 1];

            // Open the device
            using (PacketCommunicator communicator =
                   selectedDevice.Open(65536, // portion of the packet to capture
                       // 65536 guarantees that the whole packet will be captured on all the link layers
                       PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                       1000)) // read timeout
            {
                // Check the link layer. We support only Ethernet for simplicity.
                if (communicator.DataLink.Kind != DataLinkKind.Ethernet)
                {
                    Console.WriteLine("This program works only on Ethernet networks.");
                    return;
                }

                // Compile the filter
                string ipAddress = "147.135.70.223";
                using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and tcp and src host " + ipAddress))
                {
                    // Set the filter
                    communicator.SetFilter(filter);
                }

                Console.WriteLine("Listening on " + selectedDevice.Description + "...");

                communicator.ReceivePackets(0, PacketHandler);
            }
        }

        // Callback function invoked by libpcap for every incoming packet
        private static void PacketHandler(Packet packet)
        {
            IpV4Datagram ip = packet.Ethernet.IpV4;
            TcpDatagram tcp = ip.Tcp;

            // Get TCP payload (data carried by the packet)
            DataSegment tcpPayload = tcp.Payload;

            // Convert payload to byte array
            byte[] dataBytes = tcpPayload.ToArray();

            // Convert byte array to string (you may need to use an appropriate encoding)
            string dataString = System.Text.Encoding.UTF8.GetString(dataBytes);

            // Console.WriteLine(dataString);

            if (!dataString.Contains("3;19;1&")) return;

            // Console.WriteLine(dataString);
            // Console.WriteLine();

            string[] subStrings2 = dataString.Split("\0");
            string y = "";
            foreach (string s in subStrings2)
            {
                // Console.WriteLine(s);
                // Console.WriteLine();
                try
                {
                    if (s.Contains("3;19;")) y = s;
                }
                catch (Exception e)
                {
                    Console.WriteLine("e1 = " + e);
                }
            }

            // Console.WriteLine("y= " + y);
            string[] subStrings3 = [];
            try
            {
                subStrings3 = y.Split(";");
            }
            catch (Exception e)
            {
                Console.WriteLine("e2 = " + e);
            }

            string g = subStrings3[2];
            Console.WriteLine("g = " + g);

            string[] subStrings4 = [];
            try
            {
                subStrings4 = g.Split("$");
            }
            catch (Exception e)
            {
                Console.WriteLine("e3 = " + e);
            }

            // foreach (string s in subStrings4)
            // {
            //     Console.WriteLine(s);
            //     Console.WriteLine();
            // }
            string t = subStrings4[1];
            string[] subStrings5 = [];
            try
            {
                subStrings5 = t.Split("&");
            }
            catch (Exception e)
            {
                Console.WriteLine("e4 = " + e);
            }

            int countOnes = 0;
            string opponents = "";
            for (int k = 0; k < subStrings4.Length; k++)
            {
                if (subStrings4[k] == "") break;
                if (subStrings4[k][0] == '1')
                {
                    countOnes++;
                }
                else if (subStrings4[k][0] == '2')
                {
                    string[] parts = subStrings4[k].Split('&');
                    opponents += parts[1] + ",";
                }
                else break;
            }

            Console.WriteLine(countOnes + " " + opponents);

            opponents = opponents[..^1];

            for (int i = 0; i < countOnes; i++)
            {
                string[] parts = subStrings4[i].Split("&");
                string result = "";
                // result += parts[0] + "\t"; //    Party
                result += parts[1] + "\t"; //    Nick
                result += parts[2] + "\t"; //    Experience
                result += parts[24] + "\t"; //    Psycho Experience 
                result += parts[4] + "\t"; //    Gold
                result += parts[7] + " " + parts[9] + "\t"; //    Dropped items 7 item, 9 creature product 
                result += opponents;
                Console.WriteLine(result);
                PacketFound?.Invoke(result);
            }
        }
    }
}