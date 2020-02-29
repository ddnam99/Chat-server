using System.IO;
using System.Net.Sockets;

namespace Sever
{
    class User
    {
        private string Name;
        private NetworkStream Stream;
        private StreamReader Reader;
        private StreamWriter Writer;

        public User(string _Name, Socket _Socket)
        {
            Name = _Name;

            Stream =  new NetworkStream(_Socket);
            Reader = new StreamReader(Stream);
            Writer = new StreamWriter(Stream);
            GSSocket = _Socket;

            Writer.AutoFlush = true;
        }

        ~User()
        {
            Stream.Close();
            GSSocket.Close();
        }

        public string GSName { get => Name; set => Name = value; }
        public NetworkStream GSStream { get => Stream; set => Stream = value; }
        public StreamReader GSReader { get => Reader; set => Reader = value; }
        public StreamWriter GSWriter { get => Writer; set => Writer = value; }
        public Socket GSSocket { get; set; }

        public override bool Equals(object obj) 
            => GSSocket.RemoteEndPoint == (obj as User).GSSocket.RemoteEndPoint;
    }
}