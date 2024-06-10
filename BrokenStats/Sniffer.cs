using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System.Net.NetworkInformation;

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
            string[] targetIpAddresses = { "147.135.70.223", "145.239.19.54" };
            PacketDevice selectedDevice = FindActiveDevice(targetIpAddresses);

            if (selectedDevice == null)
            {
                Console.WriteLine("Postać nie jest zalogowana w grze!");
                return;
            }

            using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                string ipAddress = targetIpAddresses[0]; // Tutaj możesz wybrać dowolny adres IP z listy
                using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and tcp and src host " + ipAddress))
                {
                    communicator.SetFilter(filter);
                }

                Console.WriteLine(@"Listening on " + selectedDevice.Description + @"...");

                communicator.ReceivePackets(0, PacketHandler);
            }
        }

        private PacketDevice FindActiveDevice(string[] targetIpAddresses)
        {
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

            foreach (LivePacketDevice device in allDevices)
            {
                foreach (string ipAddress in targetIpAddresses)
                {
                    if (IsAddressReachable(ipAddress, device))
                    {
                        return device;
                    }
                }
            }

            return null;
        }

        private bool IsAddressReachable(string ipAddress, LivePacketDevice device)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions
            {
                DontFragment = true
            };

            int timeout = 10000; // 10 sekund na sprawdzenie dostępności

            try
            {
                PingReply reply = pingSender.Send(ipAddress, timeout, new byte[32], options);

                if (reply != null && reply.Status == IPStatus.Success)
                {
                    return true;
                }
            }
            catch (PingException)
            {
                // Ignoruj błędy pingowania
            }

            return false;
        }



        public static void ProcessBattleLogPacket(string packetData)
        {
            BattleLogPackedFound?.Invoke(packetData);
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