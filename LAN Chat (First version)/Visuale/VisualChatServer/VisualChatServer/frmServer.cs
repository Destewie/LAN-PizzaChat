using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace VisualChatServer
{


    public partial class frmServer : Form
    {

        static readonly List<Socket> ListaSocketsAttivi = new List<Socket>();

        static volatile IPAddress mioIPv4;
        static volatile int port;
        static volatile Socket ServerListener;
        static volatile IPEndPoint IPep;


        Socket ClientSocket = default(Socket);
        int nClient = 0;

        

        //-------------------------------------------------------------------------------------------------------------------

        public frmServer()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnAvvio_Click(object sender, EventArgs e)
        {
            try
            {
                mioIPv4 = IPAddress.Parse(txtIP.Text);
                port = int.Parse(txtPort.Text);
                IPep = new IPEndPoint(mioIPv4, port);


                ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ServerListener.Bind(IPep);
                ServerListener.Listen(100);

                Thread ThreadAccessi = new Thread(new ThreadStart(() => AccettazioneAccessi(ClientSocket)));

                ThreadAccessi.Start();



                txtChat.AppendText("Il server è in ascolto...\r\n\r\n");

                grbAvvio.Enabled = false;

                btnInvio.Enabled = true;
                txtMessaggio.Enabled = true;
                btnDisconnettiTutti.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Dati per la connessione errati", "Errore inserimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //-------------------------------------------------------------------------------------------------------------------

        private void AccettazioneAccessi(Socket client)
        {
            while (true)
            {
                client = ServerListener.Accept();
                nClient++;

                Thread ThreadGiocatore = new Thread(new ThreadStart(() => RicezioneInoltro(client)));
                ListaSocketsAttivi.Add(client);
                ThreadGiocatore.Start();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void RicezioneInoltro(Socket client)
        {
            byte[] bufferMessaggioClient = new byte[2048];
            byte[] rispostaCorta;
            int dimensioneMsgRicevto;
            bool morto = false;     //quando si digita "exit"


            dimensioneMsgRicevto = client.Receive(bufferMessaggioClient);   //il (primo) messaggio che conterrà il nome utente
            rispostaCorta = new byte[dimensioneMsgRicevto];
            Array.Copy(bufferMessaggioClient, rispostaCorta, dimensioneMsgRicevto);
            AppendTextBox(client.RemoteEndPoint + " CONNESSO CON NOME UTENTE => " + Encoding.ASCII.GetString(rispostaCorta));
            InvioMessaggio(ListaSocketsAttivi, client, "L'UTENTE " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' CONNESSO");


            while (morto == false)
            {
                try
                {
                    dimensioneMsgRicevto = client.Receive(bufferMessaggioClient);


                    if (dimensioneMsgRicevto == 0)
                        return;

                    rispostaCorta = new byte[dimensioneMsgRicevto];      //creazione di un array che riesca a contenere perfettamente (senza spazi bianchi alla fine) il messaggio ricevuto
                    Array.Copy(bufferMessaggioClient, rispostaCorta, dimensioneMsgRicevto);     //spostamento del messaggio dall'array pieno di spazi bianchi all'array della giusta dimensione

                    if (Encoding.ASCII.GetString(rispostaCorta).ToLower() == "exit")
                    {
                        Disconnessione(client);
                        morto = true;
                    }
                    else
                    {
                        AppendTextBox(client.RemoteEndPoint + " = " + Encoding.ASCII.GetString(rispostaCorta));

                        InvioMessaggio(ListaSocketsAttivi, client, Encoding.ASCII.GetString(rispostaCorta));
                    }

                }
                catch
                {
                    return;
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
            AppendTextBox(client.RemoteEndPoint + " => " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' DISCONNESSO");    //es. 192.168.1.2 => Des SI E' DISCONNESSO
            InvioMessaggio(ListaSocketsAttivi, client, "L'UTENTE " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' DICONNESSO");


            ListaSocketsAttivi.Remove(client);
            client.Shutdown(SocketShutdown.Both);
            client.Close();

        }

        //-------------------------------------------------------------------------------------------------------------------

        private void InvioMessaggio(List<Socket> clientList, Socket client, string messaggio)
        {
            byte[] risposta = Encoding.ASCII.GetBytes(messaggio);

            foreach (Socket s in clientList)
            {
                try
                {
                    if (s != client)
                        s.Send(risposta, 0, risposta.Length, SocketFlags.None);
                }
                catch
                {
                    AppendTextBox("MESSAAGGIO NON INOLTRATO!!!\r\n");
                }
            }

        }

        //-------------------------------------------------------------------------------------------------------------------

        public void AppendTextBox(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { text });
                return;
            }

            txtChat.AppendText(text + "\r\n");
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnDisconnettiTutti_Click(object sender, EventArgs e)
        {
            DisconnettiTutti();
            ListaSocketsAttivi.Clear();
        }

        //-------------------------------------------------------------------------------------------------------------------
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DisconnettiTutti();

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Environment.Exit(0);
        }

        //-------------------------------------------------------------------------------------------------------------------

        void DisconnettiTutti()
        {
            byte[] messaggioShutDown = Encoding.ASCII.GetBytes("--- IL SERVER HA CHIUSO I BATTENTI ---");
            AppendTextBox("\r\n\r\n--- TUTTI GLI UTENTI SONO STATI DISCONNESSI ---\r\n\r\n");

            foreach (Socket s in ListaSocketsAttivi)
            {
                s.Send(messaggioShutDown, 0, messaggioShutDown.Length, SocketFlags.None);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnInvio_Click(object sender, EventArgs e)
        {
            Socket s = default(Socket);

            if (txtMessaggio.Text != "")
            {
                txtChat.AppendText("Server: " + txtMessaggio.Text + "\r\n");
                InvioMessaggio(ListaSocketsAttivi, s, "Server: " + txtMessaggio.Text);
                txtMessaggio.Text = "";
            }
        }


        //-------------------------------------------------------------------------------------------------------------------
    }
}
