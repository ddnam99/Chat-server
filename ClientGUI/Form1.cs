using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ClientGUI
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private const int PORT_NUMBER = 9999;
        private static TcpClient Client = new TcpClient();
        private static StreamReader Reader;
        private static StreamWriter Writer;
        private static Stream stream;

        private void Connect()
        {
            Client.Connect(TB_IP.Text, PORT_NUMBER);
            stream = Client.GetStream();

            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
            Writer.AutoFlush = true;
        }

        private void BT_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();

                // Send machine name
                Writer.WriteLine(String.Format("{0} [{1}]", Environment.MachineName, Environment.OSVersion));

                BT_Sent.Enabled = true;
                TB_MessageSent.Enabled = true;
                TB_IP.Enabled = false;
                BT_Connect.Enabled = false;

                ReceiveMessage();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void ReceiveMessage()
        {
            while (true)
            {
                string Message = await Reader.ReadLineAsync();
                RTB_Messages.Text += Message + Environment.NewLine;
            }
        }

        private void BT_Sent_Click(object sender, EventArgs e)
        {
            string Message = TB_MessageSent.Text;

            Writer.WriteLine(Message);
            RTB_Messages.Text += "You: " + Message + Environment.NewLine;

            TB_MessageSent.Text = "";
            TB_MessageSent.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Client.Connected)
            {
                Writer.WriteLine("Exit");

                stream.Close();
                Client.Close();
            }
        }
    }
}