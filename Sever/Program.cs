using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sever
{
    public class Program
    {
        private const int PORT_NUMBER = 9999;
        private static List<User> ListUser = new List<User>();
        private static List<string> Messages = new List<string>();

        private static async Task ListenConnect(IPAddress address)
        {
            TcpListener listener = new TcpListener(address, PORT_NUMBER);
            listener.Start();
            Console.WriteLine("Server started on " + listener.LocalEndpoint);
            Console.WriteLine("Waiting for a connection...\n");

            try
            {
                while (true)
                {
                    Task<Socket> socket = listener.AcceptSocketAsync();

                    socket.Wait();

                    var Reader = new StreamReader(new NetworkStream(socket.Result));
                    User TmpUser = new User(await Reader.ReadLineAsync(), socket.Result);

                    ListUser.Add(TmpUser);

                    ReceiveMessage(TmpUser);
                    Console.WriteLine(String.Format("Connection received from {0}: {1}", socket.Result.RemoteEndPoint, TmpUser.GSName));
                }
            }
            catch { listener.Stop(); }
        }

        private static async Task ReceiveMessageOldTo(User user)
        {
            foreach (var i in Messages)
            {
                if (user.GSName == i.Split(':')[0])
                    await user.GSWriter.WriteLineAsync("You:" + i.Split(':')[1]);
                else await user.GSWriter.WriteLineAsync(i);
            }
        }

        private static async void ReceiveMessage(User user)
        {
            try
            {
                await ReceiveMessageOldTo(user);

                while (true)
                {
                    string message = await user.GSReader.ReadLineAsync();

                    if (message != null)
                        if (message.ToUpper() == "EXIT") break;
                        else
                        {
                            message = user.GSName.Split(' ')[0] + ": " + message;

                            Messages.Add(message);

                            foreach (var k in ListUser)
                                if (!k.Equals(user))
                                    k.GSWriter.WriteLine(message);
                        }
                }

                Console.WriteLine(String.Format("{0} disconnect: {1}", user.GSName, user.GSSocket.RemoteEndPoint));
            }
            catch (Exception ex) { Console.WriteLine(String.Format("{0} disconnect: {1}", user.GSName, ex.Message)); }

            ListUser.Remove(user);
        }

        private static string GetIPLocal()
        {
            foreach (var currrentIPAddress in Dns.GetHostAddresses(Dns.GetHostName()))
                if (currrentIPAddress.AddressFamily.ToString() == AddressFamily.InterNetwork.ToString())
                    return currrentIPAddress.ToString();

            return "127.0.0.1";
        }

        public static async Task Main()
        {
            Console.Title = "Sever </> Double D";
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                string IP = GetIPLocal();
                IPAddress address = IPAddress.Parse(IP);

                await ListenConnect(address);
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
        }
    }
}