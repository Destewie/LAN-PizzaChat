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

namespace VisualChatClient
{
    public partial class frmClient : Form
    {
        static volatile int port;
        static volatile IPAddress IPv4Server;
        static Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string username;
        static volatile IPEndPoint IPep;
        Thread ThreadRicezioneMessaggio;

        public frmClient()
        { 
            InitializeComponent();

            ThreadRicezioneMessaggio = new Thread(new ThreadStart(() => RicezioneRisposta(ClientSocket)));


            txtChat.Text = "Connettiti al server inserendo i dati qui sopra";
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnConnessione_Click(object sender, EventArgs e)
        {
            try
            {
                username = txtUsername.Text;
                port = int.Parse(txtPort.Text);
                IPv4Server = IPAddress.Parse(txtIP.Text);
                IPep = new IPEndPoint(IPv4Server, port);
                
                ConnessioneAlServer(ClientSocket, IPep, username);
            }
            catch
            {
                MessageBox.Show("Dati per la connessione errati", "Errore inserimento" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        void ConnessioneAlServer(Socket Client, IPEndPoint ep, string nickname)
        {
            int attempts = 0;

            while (!Client.Connected)
            {
                try
                {
                    Client.Connect(ep);
                    SendString(Client, nickname);
                }
                catch (SocketException)
                {
                    attempts++;
                    AppendTextBox("\r\nConnection attempt " + attempts);
                }
            }

            txtChat.Text = "--- CONNESSO ---\r\n\r\n";

            grbConnessione.Enabled = false;

            btnDisconnessione.Enabled = true;
            txtMessaggio.Enabled = true;
            btnInvio.Enabled = true;
            btnDisconnessione.Enabled = true;

            ThreadRicezioneMessaggio.Start();
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnDisconnessione_Click(object sender, EventArgs e)
        {
            Disconnect(ClientSocket, username);
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void Disconnect(Socket Client, string nickname)
        {
            SendString(ClientSocket, "exit");
            SendString(Client, nickname);
            ThreadRicezioneMessaggio.Abort();
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();

            AppendTextBox("\r\n\r\n--- DISCONNESSO ---");

            grbConnessione.Enabled = false;

            btnDisconnessione.Enabled = false;
            txtMessaggio.Enabled = false;
            btnInvio.Enabled = false;
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void SendString(Socket Client, string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            Client.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnInvio_Click(object sender, EventArgs e)
        {
            if (txtMessaggio.Text != "")
            {
                AppendTextBox("Tu: " + txtMessaggio.Text);
                SendString(ClientSocket, username + ": " + txtMessaggio.Text);
                txtMessaggio.Text = "";
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        void RicezioneRisposta(Socket Client)
        {
            int dimensioneRisp;

            while (true)
            {

                byte[] bufferRisposta = new byte[2048];

                try
                {
                    dimensioneRisp = Client.Receive(bufferRisposta, SocketFlags.None);
                }
                catch
                {
                    return;
                }

                if (dimensioneRisp == 0)
                    return;

                byte[] rispostaCorta = new byte[dimensioneRisp];
                Array.Copy(bufferRisposta, rispostaCorta, dimensioneRisp);

                string text = Encoding.ASCII.GetString(rispostaCorta);

                
                if (text == "--- IL SERVER HA CHIUSO I BATTENTI ---")
                {
                    ClientSocket.Shutdown(SocketShutdown.Both);
                    ClientSocket.Close();
                    AppendTextBox("\r\n\r\n\r\n" + text);

                    ModificaVisibilitaBottone(btnDisconnessione, false);
                    ModificaVisibilitaBottone(btnInvio, false);
                    ModificaVisibilitaTextBox(txtMessaggio, false);

                    return;
                }

            
                AppendTextBox(text);
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ClientSocket.Connected)
            {
                SendString(ClientSocket, "exit");
                SendString(ClientSocket, username);
                ThreadRicezioneMessaggio.Abort();
                ClientSocket.Shutdown(SocketShutdown.Both);
                ClientSocket.Close();
            }

            Environment.Exit(0);
        }

        //-------------------------------------------------------------------------------------------------------------------

        void ModificaVisibilitaBottone(Button btn, bool attivare)
        {
            btn.BeginInvoke(new MethodInvoker(() =>
            {
                btn.Enabled = attivare;
            }));
        }

        //-------------------------------------------------------------------------------------------------------------------

        void ModificaVisibilitaTextBox(TextBox txt, bool attivare)
        {
            txt.BeginInvoke(new MethodInvoker(() =>
            {
                txt.Enabled = attivare;
            }));
        }

        //-------------------------------------------------------------------------------------------------------------------

    }
}
