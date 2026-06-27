namespace LANChat.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Network.Server server = new Network.Server();
            server.Start();

            Console.WriteLine("Nhan Enter de dung server...");
            Console.ReadLine();

            server.Stop();
        }
    }
}