using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChatServer
{
    class Program
    {

        static readonly List<Socket> ListaSocketsAttivi = new List<Socket>();

        static void Main(string[] args)
        {
            Console.Title = "Server";

            Console.Write("L'IPv4 di questa scheda di rete: ");
            IPAddress mioIPv4 = IPAddress.Parse(Console.ReadLine());
            //Console.Write("Porta: ");
            int port = 7979; //int.Parse(Console.ReadLine());
            Console.Clear();

            int nClient = 0;

            Socket ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            EndPoint IPep = new IPEndPoint(mioIPv4, port);


            ServerListener.Bind(IPep);
            ServerListener.Listen(100);

            Console.WriteLine("Il server è in ascolto...  (" + mioIPv4 + ":" + port + ")\n\n");

            Socket ClientSocket = default(Socket);

            Program p = new Program();

            while (true)
            {
                nClient++;
                ClientSocket = ServerListener.Accept();

                Thread ThreadRicezioneInoltro = new Thread(new ThreadStart(() => p.RicezioneInoltro(ClientSocket)));
                ListaSocketsAttivi.Add(ClientSocket);
                ThreadRicezioneInoltro.Start();

            }
        }

        //-------------------------------------------------------------------------------------------------------------------
        /*  FUNZIONA SOLO QUANDO NON HAI TANTE SCHEDE DI RETE
         
        public static IPAddress GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var IP in host.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                {
                    return IP;
                }
            }

            throw new ExcIPeption("Indirizzo IP locale non trovato!");
        }*/

        //-------------------------------------------------------------------------------------------------------------------

        public void RicezioneInoltro(Socket client)
        {
            byte[] bufferMessaggioClient = new byte[2048];
            byte[] rispostaCorta;
            int dimensioneMsgRicevto;
            bool morto = false;     //quando si digita "exit"


            dimensioneMsgRicevto = client.Receive(bufferMessaggioClient);   //il (primo) messaggio che conterrà il nome utente
            rispostaCorta = new byte[dimensioneMsgRicevto];      
            Array.Copy(bufferMessaggioClient, rispostaCorta, dimensioneMsgRicevto);
            Console.WriteLine(client.RemoteEndPoint + " CONNESSO CON NOME UTENTE => " + Encoding.ASCII.GetString(rispostaCorta));
            InvioMessaggio(ListaSocketsAttivi, client, "L'UTENTE " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' CONNESSO");


            while (morto == false)
            {
                dimensioneMsgRicevto = client.Receive(bufferMessaggioClient);

                if (dimensioneMsgRicevto == 0)
                    return;

                rispostaCorta = new byte[dimensioneMsgRicevto];      //creazione di un array che riesca a contenere perfettamente (senza spazi bianchi alla fine) il messaggio ricevuto
                Array.Copy(bufferMessaggioClient, rispostaCorta, dimensioneMsgRicevto);     //spostamento del messaggio dall'array pieno di spazi bianchi all'array della giusta dimensione
                
                if(Encoding.ASCII.GetString(rispostaCorta).ToLower() == "exit")
                {
                    Disconnessione(client);
                    morto = true;
                }
                else
                {
                    Console.WriteLine(client.RemoteEndPoint + " = " + Encoding.ASCII.GetString(rispostaCorta));

                    InvioMessaggio(ListaSocketsAttivi, client, Encoding.ASCII.GetString(rispostaCorta));
                }
            }
            
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void Disconnessione(Socket client)
        {
            byte[] bufferMessaggioClient = new byte[2048];
            byte[] rispostaCorta;
            int dimensioneMsgRicevto;

            dimensioneMsgRicevto = client.Receive(bufferMessaggioClient);   //il (primo) messaggio che conterrà : nome utente CONNESSO
            rispostaCorta = new byte[dimensioneMsgRicevto];
            Array.Copy(bufferMessaggioClient, rispostaCorta, dimensioneMsgRicevto);
            Console.WriteLine(client.RemoteEndPoint + " => " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' DISCONNESSO");    //es. 192.168.1.2 => Des SI E' DISCONNESSO
            InvioMessaggio(ListaSocketsAttivi, client, "L'UTENTE " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' DICONNESSO");


            ListaSocketsAttivi.Remove(client);
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            
        }

        //-------------------------------------------------------------------------------------------------------------------

        private static void InvioMessaggio(List<Socket> clientList, Socket client, string messaggio)
        {
            byte[] risposta = Encoding.ASCII.GetBytes(/*client.RemoteEndPoint + ": " +*/ messaggio);

            foreach(Socket s in clientList)
            {
                if(s != client)
                     s.Send(risposta, 0, risposta.Length, SocketFlags.None);
            }
            
        }

        //-------------------------------------------------------------------------------------------------------------------
    }

}
