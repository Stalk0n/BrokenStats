using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace InterpretingThePackets
{
    class Sniffer
    {
        static void Main(string[] args)
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

            int deviceIndex = 0;
            do
            {
                Console.WriteLine("Enter the interface number (1-" + allDevices.Count + "):");
                string deviceIndexString = Console.ReadLine();
                if (!int.TryParse(deviceIndexString, out deviceIndex) ||
                    deviceIndex < 1 || deviceIndex > allDevices.Count)
                {
                    deviceIndex = 0;
                }
            } while (deviceIndex == 0);

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

                // Save file location
                // string filePath = "C:\\Users\\mrsta\\OneDrive\\Pulpit\\Solution1\\out.txt";

                /*
                // Redirect output from console to file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Console.SetOut(writer);

                    // start the capture
                    communicator.ReceivePackets(0, PacketHandler);
                }
                */
                communicator.ReceivePackets(0, PacketHandler);
            }
        }

        // Callback function invoked by libpcap for every incoming packet
        private static void PacketHandler(Packet packet)
        {
            // print timestamp and length of the packet
            // Console.WriteLine(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff") + " length:" + packet.Length);

            IpV4Datagram ip = packet.Ethernet.IpV4;
            TcpDatagram tcp = ip.Tcp;

            // Get TCP payload (data carried by the packet)
            DataSegment tcpPayload = tcp.Payload;

            // Convert payload to byte array
            byte[] dataBytes = tcpPayload.ToArray();

            // Convert byte array to string (you may need to use an appropriate encoding)
            string dataString = System.Text.Encoding.UTF8.GetString(dataBytes);

            // Print the data
            // Console.WriteLine("Data carried by the TCP packet:");
            // if (dataString.Length >= 750) return;
            // if (dataString.Length <= 42) return;

            if (!dataString.Contains("3;19;1&")) return;
            
            // Console.WriteLine(dataString);
            // Console.WriteLine();
            
            int indexOfFirstAmpersand = dataString.IndexOf('&');

            dataString = dataString.Substring(indexOfFirstAmpersand - 1);

            string[] subStrings = dataString.Split('$');

            // int participantsCount = dataString.Count(c => c == '$');

            int countOnes = 0;
            string opponents = "";
            for (int k = 0; k < subStrings.Length; k++)
            {
                if (subStrings[k][0] == '1')
                {
                    countOnes++;
                }
                else if (subStrings[k][0] == '2')
                {
                    string[] parts = subStrings[k].Split('&');

                    opponents += parts[1] + ",";
                }
                else break;
            }

            opponents = opponents[..^1];

            for (int k = 0; k < countOnes; k++)
            {
                string[] parts = subStrings[k].Split('&');
                string result = "";
                // result += parts[0] + "\t"; //    Party
                result += parts[1] + "\t"; //    Nick
                result += parts[2] + "\t"; //    Experience
                result += parts[3] + "\t"; //    Psycho Experience
                result += parts[4] + "\t"; //    Gold
                result += parts[5] + "\t"; //    Dropped items
                result += opponents;
                Console.WriteLine(result);
            }


            // print ip addresses and tcp ports
            // Console.WriteLine(ip.Source + ":" + tcp.SourcePort+ " -> " + ip.Destination + ":" + tcp.DestinationPort);
        }
    }
}