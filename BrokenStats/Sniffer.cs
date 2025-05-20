using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System.Net.NetworkInformation;
using System.Linq;
namespace BrokenStats
{
    class Sniffer
    {
        private PacketDevice selectedDevice;
        private string[] targetIpAddresses = { "146.59.111.11", "147.135.70.223", "145.239.19.54" };
        private string logFilePath = "packet_log.txt"; // Możesz zmienić ścieżkę


        public Sniffer(PacketDevice selectedDevice)
        {
            this.selectedDevice = selectedDevice;
        }

        public delegate void BattleLogPackedFoundEventHandler(string packetData);

        public static event BattleLogPackedFoundEventHandler? BattleLogPackedFound;


        public delegate void ChatLogPacketFoundEventHandler(string packetData);

        public static event ChatLogPacketFoundEventHandler? ChatLogPacketFound;

        public void Start()
        {
            if (selectedDevice == null)
            {
                Console.WriteLine("Postać nie jest zalogowana w grze!");
                return;
            }

            // Filtr na ruch do i z podanych IP
            string ipFilter = string.Join(" or ", targetIpAddresses.Select(ip => $"host {ip}"));
            using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and tcp and (" + ipFilter + ")"))
                {
                    communicator.SetFilter(filter);
                }

                Console.WriteLine(@"Listening on " + selectedDevice.Description + @"...");

                communicator.ReceivePackets(0, packet => PacketHandler(packet, targetIpAddresses));
            }
        }

        // Nowy handler z logowaniem
        private void PacketHandler(Packet packet, string[] targetIpAddresses)
        {
            // Loguj każdy pakiet do/z podanych IP
            var ip = packet.Ethernet.IpV4;
            if (ip == null) return;

            string src = ip.Source.ToString();
            string dst = ip.Destination.ToString();

            if (targetIpAddresses.Contains(src) || targetIpAddresses.Contains(dst))
            {
                LogPacket(packet, src, dst);
            }

            // ...reszta dotychczasowego kodu PacketHandler...
            // Możesz tu wywołać dotychczasowy kod, np.:
            PacketHandler(packet); // Jeśli chcesz zachować starą logikę
        }

        private void LogPacket(Packet packet, string src, string dst)
        {
            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\tSRC: {src}\tDST: {dst}\tLEN: {packet.Length}";
            try
            {
                File.AppendAllText(logFilePath, logLine + Environment.NewLine);
            }
            catch (IOException ex)
            {
                // Obsłuż błąd zapisu, np. wyświetl w konsoli
                Console.WriteLine("Błąd zapisu logu: " + ex.Message);
            }
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

        private void PacketHandlerTryCatch(Packet packet, string[] targetIpAddresses)
        {
            try
            {
                // Loguj każdy pakiet do/z podanych IP
                var ip = packet.Ethernet.IpV4;
                if (ip == null) return;

                string src = ip.Source.ToString();
                string dst = ip.Destination.ToString();

                if (targetIpAddresses.Contains(src) || targetIpAddresses.Contains(dst))
                {
                    LogPacket(packet, src, dst);
                }

                // Wywołaj dotychczasową logikę (statyczny handler)
                PacketHandler(packet);
            }
            catch (Exception ex)
            {
                LogPacketError(packet, ex);
            }
        }

        // Callback function invoked by libpcap for every incoming packet
        private void PacketHandler(Packet packet)
        {
            try
            {
                var ip = packet.Ethernet.IpV4;
                if (ip == null) return;

                string src = ip.Source.ToString();
                string dst = ip.Destination.ToString();

                if (targetIpAddresses.Contains(src) || targetIpAddresses.Contains(dst))
                {
                    LogPacket(packet, src, dst);
                }

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

                    if (!string.IsNullOrEmpty(opponents))
                        opponents = opponents[..^1];


                    for (int i = 0; i < countOnes; i++)
                    {
                        string[] parts = eachCharacterData[i].Split("&");
                        string result = "";
                        // result += parts[0] + "\t"; //    Party
                        result += parts[1] + "\t"; //    Nick
                        result += parts[2] + "\t"; //    Experience
                        string psychoExperience = parts[24];

                        if (!string.IsNullOrEmpty(parts[7]) && parts[7].All(char.IsDigit))
                        {
                            psychoExperience = parts[7];
                        }
                        result += psychoExperience + "\t"; // Psycho Experience

                        result += parts[4] + "\t"; //    Gold
                        result += parts[7] + " " + parts[9] + " " + parts[25] + "\t"; //    Dropped items: [7] item, [9] creature product 
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
            catch (Exception ex)
            {
                LogPacketError(packet, ex);
            }
        }

        private void LogPacketError(Packet packet, Exception ex)
        {
            string errorLogPath = "packet_errors.txt";
            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\tERROR: {ex.Message}\n";
            logLine += $"Packet: {BitConverter.ToString(packet.Buffer)}\n";
            try
            {
                File.AppendAllText(errorLogPath, logLine + Environment.NewLine);
            }
            catch
            {
                // Jeśli nawet logowanie błędu się nie uda, pomiń
            }
        }
    }
}