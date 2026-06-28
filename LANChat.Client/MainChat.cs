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
            lstOnlineUsers.Items.Add("Trâm");
            lstOnlineUsers.Items.Add("Trí");
            lstOnlineUsers.Items.Add("Thầy Giáo");

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
                    LANChat.Common.Message message =
                        JsonSerializer.Deserialize<LANChat.Common.Message>(json);

                    if (message == null) continue;

                    if (message.Type == MessageType.GlobalChat)
                    {
                        // Chat chung: Ai cũng được hiển thị lên màn hình
                        AddMessageToBox(message.Sender + ": " + message.Content);
                    }
                    else if (message.Type == MessageType.PrivateChat)
                    {
                        // Chat riêng: Chỉ hiển thị nếu Mình là Người nhận HOẶC Mình là Người gửi
                        if (message.Receiver == userName || message.Sender == userName)
                        {
                            AddMessageToBox(message.Sender + " (Riêng): " + message.Content);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AddMessageToBox("Loi nhan: " + ex.Message);
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
                LANChat.Common.Message message = new LANChat.Common.Message();
                message.Sender = userName;

                // Kiểm tra xem người dùng có đang bấm chọn ai trong danh sách online bên phải không
                if (lstOnlineUsers.SelectedIndex != -1)
                {
                    // CÓ CHỌN -> Chuyển gói tin thành dạng Chat Riêng tư
                    message.Type = MessageType.PrivateChat;

                    // Trích xuất tên người nhận và gán thẳng vào trường Receiver để Server định tuyến
                    string nguoiNhan = lstOnlineUsers.SelectedItem.ToString();
                    message.Receiver = nguoiNhan;
                    message.Content = txtMessage.Text;
                }
                else
                {
                    message.Type = MessageType.GlobalChat;
                    message.Content = txtMessage.Text;
                }

                string json = JsonSerializer.Serialize(message);
                byte[] data = Encoding.UTF8.GetBytes(json);
                stream.Write(data, 0, data.Length);
                txtMessage.Clear();

                // Tự động bỏ chọn người dùng sau khi gửi để tin nhắn tiếp theo tự động về chat chung
                lstOnlineUsers.ClearSelected();
            }
        }
        private void MainChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                LANChat.Common.Message logout = new LANChat.Common.Message
                {
                    Type = MessageType.Logout,
                    Sender = userName
                };

                string json = JsonSerializer.Serialize(logout);
                byte[] data = Encoding.UTF8.GetBytes(json);

                stream.Write(data, 0, data.Length);
                stream.Flush();

                Thread.Sleep(300);
            }
            catch
            {
            }

            stream?.Close();
            client?.Close();
        }
    }
}