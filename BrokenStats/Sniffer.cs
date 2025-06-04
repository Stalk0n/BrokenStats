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

            string ipFilter = string.Join(" or ", targetIpAddresses.Select(ip => $"host {ip}"));
            using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                using (BerkeleyPacketFilter filter = communicator.CreateFilter("ip and tcp and (" + ipFilter + ")"))
                {
                    communicator.SetFilter(filter);
                }

                Console.WriteLine(@"Listening on " + selectedDevice.Description + @"...");

                communicator.ReceivePackets(0, packet => PacketHandler(packet));
            }
        }

        private void PacketHandler(Packet packet)
        {
            try
            {
                var ip = packet.Ethernet.IpV4;
                if (ip == null) return;

                TcpDatagram tcp = ip.Tcp;
                if (tcp == null) return;

                if (tcp.Payload == null || tcp.Payload.Length == 0)
                    return;

                string src = ip.Source.ToString();
                string dst = ip.Destination.ToString();

                if (targetIpAddresses.Contains(src) || targetIpAddresses.Contains(dst))
                {
                    LogPacket(packet, src, dst);
                }

                DataSegment tcpPayload = tcp.Payload;

                byte[] dataBytes = tcpPayload.ToArray();

                string dataString = System.Text.Encoding.UTF8.GetString(dataBytes);

                if (dataString.StartsWith("4,"))
                {
                    LogPartyStatusPacket(dataString);
                }

                if (dataString.StartsWith("3;"))
                {
                    LogBattleProgressPacket(dataString);
                }

                if (dataString.Contains("3;19;1&"))
                {
                    BattleResultProcess(dataString);

                }
                else if (dataString.Contains("2;10;"))
                {
                    ChatMessagesControl(dataString);
                }
            }
            catch (Exception ex)
            {
                LogPacketError(packet, ex);
            }
        }

        private void LogPacket(Packet packet, string src, string dst)
        {
            // Pobierz payload TCP jeśli istnieje
            string payloadHex = "";
            string payloadText = "";

            try
            {
                var ip = packet.Ethernet.IpV4;
                if (ip != null)
                {
                    var tcp = ip.Tcp;
                    if (tcp != null)
                    {
                        var payload = tcp.Payload;
                        byte[] dataBytes = payload.ToArray();
                        payloadHex = BitConverter.ToString(dataBytes);
                        // Próbuj zdekodować jako UTF8, jeśli się nie uda zostaw puste
                        try
                        {
                            payloadText = System.Text.Encoding.UTF8.GetString(dataBytes);
                        }
                        catch { payloadText = ""; }
                    }
                }
            }
            catch { /* ignoruj błędy przy pobieraniu payload */ }

            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\tSRC: {src}\tDST: {dst}\tLEN: {packet.Length}\n" +
                             $"HEX: {payloadHex}\n" +
                             $"TXT: {payloadText}\n";

            try
            {
                File.AppendAllText(logFilePath, logLine + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Błąd zapisu logu: " + ex.Message);
            }
        }

        private void LogPacketError(Packet packet, Exception ex)
        {
            string errorLogPath = "packet_errors.txt";
            string payloadHex = "";
            string payloadText = "";

            try
            {
                var ip = packet.Ethernet.IpV4;
                if (ip != null)
                {
                    var tcp = ip.Tcp;
                    if (tcp != null)
                    {
                        var payload = tcp.Payload;
                        byte[] dataBytes = payload.ToArray();
                        payloadHex = BitConverter.ToString(dataBytes);
                        try
                        {
                            payloadText = System.Text.Encoding.UTF8.GetString(dataBytes);
                        }
                        catch { payloadText = ""; }
                    }
                }
            }
            catch { /* ignoruj błędy przy pobieraniu payload */ }

            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\tERROR: {ex.Message}\n" +
                             $"Packet: {BitConverter.ToString(packet.Buffer)}\n" +
                             $"HEX: {payloadHex}\n" +
                             $"TXT: {payloadText}\n";

            try
            {
                File.AppendAllText(errorLogPath, logLine + Environment.NewLine);
            }
            catch
            {
                // Jeśli nawet logowanie błędu się nie uda, pomiń
            }
        }

        private void BattleResultProcess(string dataString)
        {
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

        private void ChatMessagesControl(string dataString)
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

        private void LogBattleProgressPacket(string txt)
        {
            string battleLogPath = "battle_progress_log.txt";
            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\nTXT: {txt}\n";
            try
            {
                File.AppendAllText(battleLogPath, logLine + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Błąd zapisu przebiegu walki: " + ex.Message);
            }
        }

        private void LogPartyStatusPacket(string txt)
        {
            string statusLogPath = "party_status_log.txt";
            string logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\nTXT: {txt}\n";
            try
            {
                File.AppendAllText(statusLogPath, logLine + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Błąd zapisu statusu drużyny: " + ex.Message);
            }
        }

    }
}