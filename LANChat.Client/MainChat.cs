using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.Json;
using LANChat.Common;

namespace WindowsFormsApp1
{
    public partial class MainChat : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string userName;

        public MainChat(string ip, int port, string user)
        {
            InitializeComponent();
            this.Text = "Phòng Chat - " + user; 
            userName = user;
            ConnectToServer(ip, port);
        }

        private void ConnectToServer(string ip, int port)
        {
            try
            {
                client = new TcpClient();
                client.Connect(ip, port);
                stream = client.GetStream();
                LANChat.Common.Message loginMessage = new LANChat.Common.Message
                {
                    Type = MessageType.Login,
                    Sender = userName
                };

                string json = JsonSerializer.Serialize(loginMessage);
                byte[] data = Encoding.UTF8.GetBytes(json);
                stream.Write(data, 0, data.Length);

                Thread listenThread = new Thread(ReceiveMessage);
                listenThread.IsBackground = true;
                listenThread.Start();

                AddMessageToBox("Hệ thống: Đã kết nối thành công tới Server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy Server! Vui lòng bật Server trước. Lỗi: " + ex.Message);
            }
        }

        private void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesRead = stream.Read(data, 0, data.Length);

                    if (bytesRead == 0) break;

                    string json = Encoding.UTF8.GetString(data, 0, bytesRead);
                    LANChat.Common.Message message = JsonSerializer.Deserialize<LANChat.Common.Message>(json);

                    if (message != null)
                    {
                        AddMessageToBox(message.Sender + ": " + message.Content);
                    }
                }
            }
            catch
            {
                if (client != null) client.Close();
            }
        }

        private void AddMessageToBox(string msg)
        {
            if (rtbChat.InvokeRequired)
            {
                rtbChat.Invoke(new Action(() => rtbChat.AppendText(msg + Environment.NewLine)));
            }
            else
            {
                rtbChat.AppendText(msg + Environment.NewLine);
            }
        }

        public void btnGui_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMessage.Text) && stream != null)
            {
                LANChat.Common.Message message = new LANChat.Common.Message
                {
                    Type = MessageType.GlobalChat,
                    Sender = userName,
                    Content = txtMessage.Text
                };

                string json = JsonSerializer.Serialize(message);
                byte[] data = Encoding.UTF8.GetBytes(json);
                stream.Write(data, 0, data.Length);
                txtMessage.Clear();
            }
        }

        private void MainChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
            Application.Exit();
        }
    }
}