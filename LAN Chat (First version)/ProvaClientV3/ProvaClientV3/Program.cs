using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatClient
{
    class Program
    {
        //static volatile int posCursoreDaTop = 10;

        static void Main(string[] args)
        {
            int port = 7979;

            Console.Title = "Client";

            Console.Write("Inserisci l'indirizzo IP del server: ");
            IPAddress IPv4Server = IPAddress.Parse(Console.ReadLine());
            Console.Write("Username: ");
            string username = Console.ReadLine();  

            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPep = new IPEndPoint(IPv4Server/*IPAddress.Parse("192.168.30.9")*/, port);

            ConnessioneAlServer(ClientSocket, IPep, username);
            RequestLoop(ClientSocket, username);
            Exit(ClientSocket, username);
        }


        //-------------------------------------------------------------------------------------------------------------------

        private static void ConnessioneAlServer(Socket Client, IPEndPoint ep, string nickname)
        {
            int attempts = 0;

            while (!Client.Connected)
            {
                try
                {
                    attempts++;
                    Console.WriteLine("Connection attempt " + attempts);
                    Client.Connect(ep);
                }
                catch (SocketException)
                {
                    Console.Clear();
                }
            }

            Console.Clear();
            Console.WriteLine("BENVENUTO NEL CHAT SERVER, " + nickname + "!! (server ospitato da " + ep.Address + ":" + ep.Port + ")\n\n");
        }

        //-------------------------------------------------------------------------------------------------------------------

        private static void RequestLoop(Socket Client, string nickname)
        {
            Console.WriteLine("Digita 'exit' per disconnetterti\n\n");
            Program pInvio = new Program();
            Program pRicezione = new Program();

            Thread ThreadInvioMessaggio = new Thread(new ThreadStart(() => InvioMessaggio(Client, nickname)));
            Thread ThreadRicezioneMessaggio = new Thread(new ThreadStart(() => RicezioneRisposta(Client)));

            ThreadInvioMessaggio.Start();
            ThreadRicezioneMessaggio.Start();

            while(true)
            {
                Thread.Sleep(200);
            }

            /*
            while (true)
            {
                InvioMessaggio(Client);
                RicezioneRisposta(Client);
            }*/
        }

        //-------------------------------------------------------------------------------------------------------------------

        private static void InvioMessaggio(Socket Client, string nickname)
        {
            string text;

            SendString(Client, nickname);  //primo messaggio per comunicare agli altri il nick

            while (true)
            {
                //Console.SetCursorPosition(0, posCursoreDaTop + 5);
                text = Console.ReadLine();
                //Console.SetCursorPosition(0, posCursoreDaTop + 5);
               // Console.Write("                                                     ");
                //Console.SetCursorPosition(0, posCursoreDaTop);
                //Console.Write("Tu: " + text);
                //posCursoreDaTop++;
                //Console.SetCursorPosition(0, posCursoreDaTop);


                if (text != "")
                {
                    if (text.ToLower() == "exit")
                    {
                        Exit(Client, nickname);
                    }

                    SendString(Client, nickname + ": " + text);
                }

            }
            
        }

        //-------------------------------------------------------------------------------------------------------------------

        private static void SendString(Socket Client, string fullText)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(fullText);
            Client.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        //-------------------------------------------------------------------------------------------------------------------

        private static void RicezioneRisposta(Socket Client)
        {

            while (true)
            {

                byte[] bufferRisposta = new byte[2048];
                int dimensioneRisp = Client.Receive(bufferRisposta, SocketFlags.None);

                if (dimensioneRisp == 0)
                    return;

                byte[] rispostaCorta = new byte[dimensioneRisp];

                Array.Copy(bufferRisposta, rispostaCorta, dimensioneRisp);

                string text = Encoding.ASCII.GetString(rispostaCorta);

                //Console.SetCursorPosition(0, posCursoreDaTop - 5);
                Console.WriteLine(text);
                //posCursoreDaTop++;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private static void Exit(Socket Client, string nickname)
        {
            SendString(Client, "exit");
            SendString(Client, nickname);
            Client.Shutdown(SocketShutdown.Both);
            Client.Close();
            Environment.Exit(0);
        }

        //-------------------------------------------------------------------------------------------------------------------

    }
}
