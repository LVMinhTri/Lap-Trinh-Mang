using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using LANChat.Common;
using LANChat.Server.Services;

namespace LANChat.Server.Network
{
    public class Server
    {
        private TcpListener _listener;
        private bool _isRunning;

        public UserManager UserManager { get; }

        public Server()
        {
            UserManager = new UserManager();
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, Constants.SERVER_PORT);

            _listener.Start();

            _isRunning = true;

            Console.WriteLine($"Server started at port {Constants.SERVER_PORT}");

            Thread listenThread = new Thread(ListenForClients);
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        public void Stop()
        {
            _isRunning = false;

            _listener?.Stop();

            Console.WriteLine("Server stopped.");
        }

        private void ListenForClients()
        {
            while (_isRunning)
            {
                try
                {
                    TcpClient tcpClient = _listener.AcceptTcpClient();

                    Console.WriteLine("New client connected.");

                    ClientHandler handler = new ClientHandler(tcpClient, UserManager);
                    handler.Start();
                }
                catch
                {
                    break;
                }
            }
        }
    }
}