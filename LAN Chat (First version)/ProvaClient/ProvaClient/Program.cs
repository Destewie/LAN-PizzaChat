using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProvaClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 7979;
            string ipAddress = "127.0.0.1";

            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint ep = new IPEndPoint(IPAddress.Parse(ipAddress), port);

            ClientSocket.Connect(ep);

            Console.WriteLine("Client connesso!");

            while(true)
            {
                string messaggioDalClient = "";

                Console.Write("Scrivi il messaggio: ");
                messaggioDalClient = Console.ReadLine();

                ClientSocket.Send(System.Text.Encoding.ASCII.GetBytes(messaggioDalClient), 0, messaggioDalClient.Length, SocketFlags.None);



                byte[] messaggioDalServer = new byte[1024];
                int dimensione = ClientSocket.Receive(messaggioDalServer);

                Console.WriteLine("Server: " + System.Text.Encoding.ASCII.GetString(messaggioDalServer, 0, dimensione));
            }

        }

    }
}
