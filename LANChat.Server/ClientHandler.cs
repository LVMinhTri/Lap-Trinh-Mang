using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using LANChat.Common;
using LANChat.Server.Models;

namespace LANChat.Server
{
    public class ClientHandler
    {
        private ClientInfo clientInfo;
        private TcpClient tcpClient;
        private NetworkStream stream;
        private UserManager userManager;
        private Thread receiveThread;
        private bool isRunning;

        public ClientHandler(TcpClient client, UserManager manager)
        {
            tcpClient = client;
            stream = tcpClient.GetStream();
            userManager = manager;
        }

        // Bat dau xu ly client
        public void Start()
        {
            isRunning = true;

            receiveThread = new Thread(ReceiveLoop);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        // Lang nghe du lieu tu client
        private void ReceiveLoop()
        {
            byte[] buffer = new byte[Constants.BUFFER_SIZE];

            while (isRunning)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        break;
                    }

                    string json = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    Message? message = JsonSerializer.Deserialize<Message>(json);

                    if (message == null)
                    {
                        continue;
                    }

                        switch (message.Type)
                        {
                            case MessageType.Login:
                                HandleLogin(message);
                                break;
}                }
                catch
                {
                    break;
                }
            }

            Close();
        }
        // Xu ly dang nhap
        private void HandleLogin(Message message)
        {
            // Kiem tra nickname da ton tai chua
            if (userManager.IsNicknameExists(message.Sender))
            {
                Message response = new Message
                {
                    Type = MessageType.LoginFailed,
                    Content = "Nickname da ton tai."
                };

                SendMessage(response);
                return;
            }

            // Tao thong tin client
            clientInfo = new ClientInfo
            {
                Nickname = message.Sender,
                TcpClient = tcpClient,
                Stream = stream
            };

            userManager.AddClient(clientInfo);

            Console.WriteLine($"{clientInfo.Nickname} da dang nhap.");

            Message success = new Message
            {
                Type = MessageType.LoginSuccess,
                Content = "Dang nhap thanh cong."
            };

            SendMessage(success);
        }
        // Gui du lieu den client
        private void SendMessage(Message message)
        {
            try
            {
                string json = JsonSerializer.Serialize(message);

                byte[] data = Encoding.UTF8.GetBytes(json); 

                stream.Write(data, 0, data.Length);
            }
            catch
            {

            }
        }
        // Dong ket noi
        public void Close()
        {
            isRunning = false;

            if (stream != null)
                stream.Close();

            if (tcpClient != null)
                tcpClient.Close();

            Console.WriteLine("Client da ngat ket noi.");
        }
    }
}