using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using LANChat.Common;

namespace LANChat.Server
{
    public class ClientHandler
    {
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

                    Console.WriteLine($"Nhan duoc: {message.Type}");
                }
                catch
                {
                    break;
                }
            }

            Close();
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