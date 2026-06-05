using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Program
{
    static Random rnd = new Random();

    static int state = 1;
    static int produced = 0;
    static int reject = 0;

    static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();

        Console.WriteLine("PLC Simülatörü Başladı...");

        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("Client Bağlandı.");

        NetworkStream stream = client.GetStream();

        int packetID = 0;

        while (true)
        {
            if (stream.DataAvailable)
            {
                byte[] buffer = new byte[100];
                int len = stream.Read(buffer, 0, buffer.Length);

                string cmd = Encoding.ASCII.GetString(buffer, 0, len).Trim();

                if (cmd == "START")
                {
                    state = 1;
                    Console.WriteLine("START alındı");
                }

                if (cmd == "RESTART")
                {
                    state = 1;
                    produced = 0;
                    reject = 0;

                    Console.WriteLine("RESTART alındı - hat yeniden başladı");
                }
            }

            if (stream.DataAvailable)
            {
                byte[] cmdBuffer = new byte[100];

                int cmdLength =
                    stream.Read(cmdBuffer, 0, cmdBuffer.Length);

                string cmd =
                    Encoding.ASCII.GetString(cmdBuffer, 0, cmdLength)
                    .Trim();

                if (cmd == "START")
                {
                    state = 1;

                    Console.WriteLine(
                        "Motor tekrar çalıştırıldı.");
                }
            }

            try
            {
                if (!client.Connected)
                    break;

                if (rnd.Next(0, 15) == 1)
                    state = rnd.Next(0, 4);

                int temp = 25;
                int motor = 0;
                int speed = 0;

                switch (state)
                {
                    case 0:
                        temp = rnd.Next(20, 30);
                        break;

                    case 1:
                        temp = rnd.Next(30, 45);
                        motor = 1;
                        speed = rnd.Next(80, 150);
                        produced += rnd.Next(1, 4);
                        reject += rnd.Next(0, 2);
                        break;

                    case 2:
                        temp = rnd.Next(45, 60);
                        break;

                    case 3:
                        temp = rnd.Next(25, 35);
                        break;
                }

                string veri =
                    $"{packetID};" +
                    $"{DateTime.Now:HH:mm:ss};" +
                    $"{state};" +
                    $"{temp};" +
                    $"{motor};" +
                    $"{speed};" +
                    $"{produced};" +
                    $"{reject};" +
                    $"{rnd.Next(1, 10)};" +
                    $"{rnd.Next(30, 90)}";

                byte[] buffer = Encoding.ASCII.GetBytes(veri + "\n");

                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();

                Console.WriteLine(veri);

                packetID++;

                Thread.Sleep(1000);
            }
            catch
            {
                Console.WriteLine("Bağlantı koptu.");
                break;
            }
        }
    }
}