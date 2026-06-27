using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using LANChat.Common;
using LANChat.Server.Models;
using System.Collections.Generic;
using LANChat.Server.Services;

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

                    Message message = JsonSerializer.Deserialize<Message>(json);

                    if (message == null)
                    {
                        continue;
                    }

                        switch (message.Type)
                        {
                            case MessageType.Login:
                                HandleLogin(message);
                                break;
                            case MessageType.GlobalChat:
                                HandleGlobalChat(message);
                                break;
                            case MessageType.PrivateChat:
                                HandlePrivateChat(message);
                                break;
                            case MessageType.Logout:
                                HandleLogout(message);
                                return;
                        }                
                    }
                catch (Exception ex)
                {
                    Console.WriteLine("ReceiveLoop ERROR: " + ex);
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
        // Xu ly chat cong khai
        private void HandleGlobalChat(Message message)
        {
            Console.WriteLine($"{message.Sender}: {message.Content}");

            Broadcast(message);
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
        // Xu ly chat rieng
        private void HandlePrivateChat(Message message)
        {
            ClientInfo receiver = userManager.GetClient(message.Receiver);

            if (receiver == null)
            {
                return;
            }

            SendToClient(receiver, message);

            Console.WriteLine($"{message.Sender} -> {message.Receiver}: {message.Content}");
        }
        // Xu ly dang xuat
        private void HandleLogout(Message message)
        {
            if (clientInfo != null)
            {
                Console.WriteLine($"{clientInfo.Nickname} da dang xuat.");
                userManager.RemoveClient(clientInfo);
                clientInfo = null;
            }

            isRunning = false;

            stream?.Close();
            tcpClient?.Close();
        }
        // Gui tin nhan den tat ca client
        private void Broadcast(Message message)
        {
            List<ClientInfo> clients = userManager.GetAllClients();

            foreach (ClientInfo client in clients)
            {
                try
                {
                    string json = JsonSerializer.Serialize(message);

                    byte[] data = Encoding.UTF8.GetBytes(json);

                    client.Stream.Write(data, 0, data.Length);
                }
                catch
                {

                }
            }
        }
        // Gui tin nhan den mot client
        private void SendToClient(ClientInfo client, Message message)
        {
            try
            {
                string json = JsonSerializer.Serialize(message);

                byte[] data = Encoding.UTF8.GetBytes(json);

                client.Stream.Write(data, 0, data.Length);
            }
            catch
            {

            }
        }
        // Dong ket noi
        // Dong ket noi
        public void Close()
        {
            isRunning = false;

            if (clientInfo != null)
            {
                Console.WriteLine($"{clientInfo.Nickname} da ngat ket noi.");
                userManager.RemoveClient(clientInfo);
                clientInfo = null;
            }

            stream?.Close();
            tcpClient?.Close();
        }
    }
}