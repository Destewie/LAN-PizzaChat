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
            grbFunzioni.Enabled = false;
            lblGusto2.Visible = false;
            cmbIngrediente2.Visible = false;
            pnlOrdina.SendToBack();

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

            grbFunzioni.Enabled = true;
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
            btnOrdina.Enabled = false;
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
                    ModificaVisibilitaBottone(btnOrdina, false);
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

        private void btnPizza_Click(object sender, EventArgs e)
        {
            pnlOrdina.BringToFront();
            txtMessaggio.Visible = false;
            btnInvio.Visible = false;
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnChat_Click(object sender, EventArgs e)
        {
            pnlOrdina.SendToBack();
            txtMessaggio.Visible = true;
            btnInvio.Visible = true;
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIngrediente1.Text == "NULL (Margherita)" || cmbIngrediente1.Text == "" || cmbIngrediente1.Text == "Quattro Formaggi")
            {
                /*BeginInvoke(new Action(() => cmbIngrediente2.Text = ""));
                cmbIngrediente2.Enabled = false;  */
                lblGusto2.Visible = false;
                cmbIngrediente2.Visible = false;
            }
            else
            {
                //cmbIngrediente2.Enabled = true;
                lblGusto2.Visible = true;
                cmbIngrediente2.Visible = true;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            cmbIngrediente1.Enabled = false;
            cmbIngrediente2.Enabled = false;
            cmbBibita.Enabled = false;
            btnOrdina.Enabled = false;

            string ordine = "";

            if(cmbIngrediente2.Visible == true  &&  cmbBibita.Text != "")
            {
                if(cmbIngrediente2.Text == "" || cmbIngrediente2.Text == "NULL")
                    ordine = username + "|" + cmbIngrediente1.Text + "||" + cmbBibita.Text; //non c'è il secondo ingrediente
                else
                    ordine = username + "|" + cmbIngrediente1.Text + "|, " + cmbIngrediente2.Text + "|" + cmbBibita.Text; //c'è un secondo ingrediente
            }
            else if (cmbIngrediente2.Visible == false && cmbBibita.Text != "")
            {
                if(cmbIngrediente1.Text == "")
                    ordine = username + "|" + "NULL(Margherita)" + "||" + cmbBibita.Text; //non ha inserito nemmeno il primo gusto
                else
                    ordine = username + "|" + cmbIngrediente1.Text + "||" + cmbBibita.Text; //ha inserito solo il primo gusto (gusto speciale tipo 4 formaggi 
            }

            SendString(ClientSocket, "pizza|" + ordine);
        }


        //-------------------------------------------------------------------------------------------------------------------

    }
}
