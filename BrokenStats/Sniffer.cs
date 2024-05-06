using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace BrokenStats
{
    class Sniffer
    {
        public delegate void BattleLogPackedFoundEventHandler(string packetData);

        public static event BattleLogPackedFoundEventHandler? BattleLogPackedFound;


        public delegate void ChatLogPacketFoundEventHandler(string packetData);

        public static event ChatLogPacketFoundEventHandler? ChatLogPacketFound;

        public void Start()
        {
            // Retrieve the device list from the local machine
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

            if (allDevices.Count == 0)
            {
                Console.WriteLine(@"No interfaces found! Make sure WinPcap is installed.");
                return;
            }

            // Print the list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                Console.Write((i + 1) + @". " + device.Name);
                if (device.Description != null)
                    Console.WriteLine(@" (" + device.Description + @")");
                else
                    Console.WriteLine(@" (No description available)");
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
                // if (communicator.DataLink.Kind != DataLinkKind.Ethernet)
                // {
                //     Console.WriteLine("This program works only on Ethernet networks.");
                //     return;
                // }

                // Compile the filter
                string ipAddress = "147.135.70.223";
                // string ipAddress = "145.239.19.54";
                using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and tcp and src host " + ipAddress))
                {
                    // Set the filter
                    communicator.SetFilter(filter);
                }

                Console.WriteLine(@"Listening on " + selectedDevice.Description + @"...");

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

            // if (!dataString.Contains("3;19;1&")) return;

            if (dataString.Contains("3;19;1&"))
            {
                // Console.WriteLine(dataString);
                // Console.WriteLine();

                string[] actualDataString = dataString.Split("\0");
                string y = "";
                foreach (string s in actualDataString)
                {
                    try
                    {
                        if (s.Contains("3;19;")) y = s;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(@"e1 = " + e);
                    }
                }

                string[] everyCharacterData = [];
                try
                {
                    everyCharacterData = y.Split(";");
                }
                catch (Exception e)
                {
                    Console.WriteLine(@"e2 = " + e);
                }

                string g = everyCharacterData[2];

                string[] eachCharacterData = [];
                try
                {
                    eachCharacterData = g.Split("$");
                }
                catch (Exception e)
                {
                    Console.WriteLine(@"e3 = " + e);
                }


                int countOnes = 0;
                string opponents = "";
                for (int k = 0; k < eachCharacterData.Length; k++)
                {
                    if (eachCharacterData[k] == "") break;
                    if (eachCharacterData[k][0] == '1')
                    {
                        countOnes++;
                    }
                    else if (eachCharacterData[k][0] == '2')
                    {
                        string[] parts = eachCharacterData[k].Split('&');
                        opponents += parts[1] + ",";
                    }
                    else break;
                }

                opponents = opponents[..^1];

                for (int i = 0; i < countOnes; i++)
                {
                    string[] parts = eachCharacterData[i].Split("&");
                    string result = "";
                    // result += parts[0] + "\t"; //    Party
                    result += parts[1] + "\t"; //    Nick
                    result += parts[2] + "\t"; //    Experience
                    result += parts[24] + "\t"; //    Psycho Experience 
                    result += parts[4] + "\t"; //    Gold
                    result += parts[7] + " " + parts[9] + "\t"; //    Dropped items: [7] item, [9] creature product 
                    result += opponents;
                    // Console.WriteLine(result);
                    BattleLogPackedFound?.Invoke(result);
                }
            }

            else if (dataString.Contains("2;10;"))
            {
                string[] actualDataString = dataString.Split(";");
                if (actualDataString[3].Count(char.IsLetter) >= 3)
                {
                    string decodedText = Uri.UnescapeDataString(actualDataString[4]);
                    // decodedText = decodedText.Substring(4);
                    string result = actualDataString[3] + " " + decodedText;
                    ChatLogPacketFound?.Invoke(result);
                }
            }
            else
            {
                return;
            }
        }
    }
}