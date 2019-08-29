using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ClientConsole
{
    public class Program
    {
        private const int PORT_NUMBER = 9999;
        private static TcpClient Client = new TcpClient();
        private static StreamReader Reader;
        private static StreamWriter Writer;
        private static Stream stream;

        private static void Connect(string _IP)
        {
            Client.Connect(_IP, PORT_NUMBER);
            stream = Client.GetStream();

            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
            Writer.AutoFlush = true;
        }

        private static void Disconnect()
        {
            stream.Close();
            Client.Close();
        }

        private static async Task SendMessage()
        {
            while (true)
            {
                string Message = await Console.In.ReadLineAsync();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine("You: " + Message);
                Writer.WriteLine(Message);
            }
        }

        private static async Task ReceiveMessage()
        {
            while (true)
            {
                string Message = await Reader.ReadLineAsync();
                Console.WriteLine(Message);
            }
        }

        public static void Main()
        {
            Console.Title = "Client </> Double D";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                Console.Write("IP Sever: ");
                string IP = Console.ReadLine();

                Connect(IP);

                // Send machine name
                Writer.WriteLine(String.Format("{0} [{1}]", Environment.MachineName, Environment.OSVersion));

                Console.WriteLine("Connected to sever.\n");

                Task.WhenAll(ReceiveMessage(), SendMessage());

                Disconnect();
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex); }
        }
    }
}