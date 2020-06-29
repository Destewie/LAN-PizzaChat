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
        long numeroClient = 0;
        long numeroOrdine = 0;

        static readonly List<Utente> ListaUtenti = new List<Utente>();

        static volatile IPAddress mioIPv4;
        static volatile int port;
        static volatile Socket ServerListener;
        static volatile IPEndPoint IPep;


        Socket ClientSocket = default(Socket);
        int nClient = 0;

        List<Ordine> Ordini = new List<Ordine>();

       
        //-------------------------------------------------------------------------------------------------------------------

        public frmServer()
        {
            InitializeComponent();

            //settaggi grafici per impostare la form all'avvio fregandosene di come l'ho impostata graficamente su visual studio 
            pnlPagamenti.SendToBack();
            pnlPagamenti.Visible = false;
            btnChat.Enabled = false;
            lblHostPizze.Text = "Host: ";
            dgvHost.BringToFront();
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
                grbVisualizzazioneDGV.Enabled = true;
                btnInvio.Enabled = true;
                txtMessaggio.Enabled = true;
                btnDisconnettiTutti.Enabled = true;
                grbVistePrincipali.Enabled = true;
                btnHost.Enabled = false;

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

                Thread ThreadRicezioneUtente = new Thread(new ThreadStart(() => RicezioneInoltro(client)));
                ThreadRicezioneUtente.Start();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void RicezioneInoltro(Socket client)
        {
            byte[] bufferMessaggioClient = new byte[2048];
            byte[] rispostaCorta;
            string messaggio;
            int dimensioneMsgRicevto;
            bool morto = false;     //quando si digita "exit"


            dimensioneMsgRicevto = client.Receive(bufferMessaggioClient);   //il (primo) messaggio che conterrà il nome utente
            rispostaCorta = new byte[dimensioneMsgRicevto];
            Array.Copy(bufferMessaggioClient, rispostaCorta, dimensioneMsgRicevto);
            AppendTextBox(client.RemoteEndPoint + " CONNESSO CON NOME UTENTE => " + Encoding.ASCII.GetString(rispostaCorta));

            Utente u = new Utente(numeroClient, client, Encoding.ASCII.GetString(rispostaCorta));
            numeroClient++;
            ListaUtenti.Add(u);
            DisplayHost();

            InvioMessaggio(UtentiAttivi(), client, "L'UTENTE " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' CONNESSO");


            while (morto == false)
            {
                try
                {
                    dimensioneMsgRicevto = client.Receive(bufferMessaggioClient);


                    if (dimensioneMsgRicevto == 0)
                        return;

                    rispostaCorta = new byte[dimensioneMsgRicevto];      //creazione di un array che riesca a contenere perfettamente (senza spazi bianchi alla fine) il messaggio ricevuto
                    Array.Copy(bufferMessaggioClient, rispostaCorta, dimensioneMsgRicevto);     //spostamento del messaggio dall'array pieno di spazi bianchi all'array della giusta dimensione
                    messaggio = Encoding.ASCII.GetString(rispostaCorta);

                    if (messaggio == "exit")
                    {
                        Disconnessione(client);
                        morto = true;
                    }
                    else if (messaggio.Length >= 5  &&  messaggio[0] == 'p' && messaggio[1] == 'i' && messaggio[2] == 'z' && messaggio[3] == 'z' && messaggio[4] == 'a') //se il messaggio è pizza vuol dire che il client sta ordinando
                    {
                        string[] temp = new string[4]; //array di tre elementi = nome, pizza, bibita
                        temp = messaggio.Split('|');

                        Pizza p = new Pizza(temp[2], temp[3], temp[4]); //in temp[0] c'è la stringa "pizza"; in temp[1] c'è lo username del richiedente
                        Ordine o = new Ordine(numeroOrdine, p, RicercaPerSocket(client));
                        numeroOrdine++;
                        Ordini.Add(o);

                        DisplayPizze();
                        cmbGestPizze.Items.Add(o.NumOrdine + ") " + o.Ut.NomeUtente + " -> " + o.Piz.Gusto1 + o.Piz.Gusto2 + " e " + o.Piz.Bibita);
                    }
                    else
                    {
                        AppendTextBox(client.RemoteEndPoint + " = " + Encoding.ASCII.GetString(rispostaCorta));

                        InvioMessaggio(UtentiAttivi(), client, Encoding.ASCII.GetString(rispostaCorta));
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
            InvioMessaggio(UtentiAttivi(), client, "L'UTENTE " + Encoding.ASCII.GetString(rispostaCorta) + " SI E' DICONNESSO");


            RicercaPerSocket(client).Attivo = false;
            client.Shutdown(SocketShutdown.Both);
            client.Close();

            DisplayHost();
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void InvioMessaggio(List<Utente> activeClientList, Socket client, string messaggio)
        {
            byte[] risposta = Encoding.ASCII.GetBytes(messaggio);

            foreach (Utente u in activeClientList)
            {
                try
                {
                    if (u.Sock != client)
                        u.Sock.Send(risposta, 0, risposta.Length, SocketFlags.None);
                }
                catch
                {
                    AppendTextBox("MESSAGGIO NON INOLTRATO!!!\r\n");
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

        public void DeleteDGV(DataGridView d)
        {
            d.BeginInvoke(new MethodInvoker(() =>
            {
                d.Rows.Clear();
            }));
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnDisconnettiTutti_Click(object sender, EventArgs e)
        {
            DisconnettiTutti();
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

            foreach (Utente u in UtentiAttivi())
            {
                u.Attivo = false;
                u.Sock.Send(messaggioShutDown, 0, messaggioShutDown.Length, SocketFlags.None);
            }

            DeleteDGV(dgvHost);
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnInvio_Click(object sender, EventArgs e)
        {
            Socket s = default(Socket);

            if (txtMessaggio.Text != "")
            {
                txtChat.AppendText("Server: " + txtMessaggio.Text + "\r\n");
                InvioMessaggio(UtentiAttivi(), s, "Server: " + txtMessaggio.Text);
                txtMessaggio.Text = "";
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnPizze_Click(object sender, EventArgs e)
        {
            btnPizze.Enabled = false;
            btnHost.Enabled = true;
            lblHostPizze.Text = "Pizze:";
            dgvPizze.BringToFront();
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnHost_Click(object sender, EventArgs e)
        {
            btnPizze.Enabled = true;
            btnHost.Enabled = false;
            lblHostPizze.Text = "Host:";
            dgvHost.BringToFront();
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnGestione_Click(object sender, EventArgs e)
        {
            btnChat.Enabled = true;
            btnGestione.Enabled = false;
            pnlPagamenti.BringToFront();
            pnlPagamenti.Visible = true;
        }

        //-------------------------------------------------------------------------------------------------------------------

        private List<Utente> UtentiAttivi()     //Ritorna la lista degli utenti attivi tra tutti gli utenti registrati
        {
            List<Utente> UtAtt = new List<Utente>();

            foreach (Utente u in ListaUtenti)
            {
                if (u.Attivo == true)
                    UtAtt.Add(u);
            }

            return UtAtt;
        }

        //-------------------------------------------------------------------------------------------------------------------

        private Utente RicercaPerSocket(Socket s)
        {
            foreach (Utente u in UtentiAttivi())
            {
                if (u.Sock == s)
                    return u;
            }

            return null;
        }

        //-------------------------------------------------------------------------------------------------------------------

        public void DisplayHost()
        {
            DeleteDGV(dgvHost);

            foreach (Utente u in UtentiAttivi())
            {
                dgvHost.BeginInvoke(new MethodInvoker(() =>
                {
                    dgvHost.Rows.Add(u.NumUtente, u.NomeUtente, u.Sock.RemoteEndPoint.ToString());
                }));
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        public void DisplayPizze()
        {
            DeleteDGV(dgvPizze);

            foreach (Ordine o in Ordini)
            {
                dgvPizze.BeginInvoke(new MethodInvoker(() =>
                {
                    dgvPizze.Rows.Add(o.NumOrdine, o.Ut.NomeUtente, o.Piz.Gusto1 + o.Piz.Gusto2, o.Piz.Bibita, o.Pagato);
                }));
            }
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnChat_Click(object sender, EventArgs e)
        {
            btnChat.Enabled = false;
            btnGestione.Enabled = true;
            pnlPagamenti.SendToBack();
            pnlPagamenti.Visible = false;
        }


        //-------------------------------------------------------------------------------------------------------------------

        private int CercaBibitaNellaStampa(string bibita, List<string> bibiteOrdine)
        {
            int cont = 0;

            foreach (string s in bibiteOrdine)
            {
                if (s == bibita)
                {
                    return cont;
                }

                cont++;
            }

            return -1;
        }

        //-------------------------------------------------------------------------------------------------------------------

        private int CercaGustoNellaStampa(string gusto, List<string> gustiOrdine)
        {
            int cont = 0;

            foreach (string s in gustiOrdine)
            {
                if (s == gusto)
                {
                    return cont;
                }

                cont++;
            }

            return -1;
        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnStampa_Click(object sender, EventArgs e)
        {
            string ordineFinale;
            int indGusti = 0;
            int indBibite = 0;

            List<string> gustiOrdinati = new List<string>();
            List<int> nOrdiniGusto = new List<int>();   //lista parallela a "gustiOrdinati" per dire quante copie di quel gusto sono state ordinate
            List<string> bibiteOrdinate = new List<string>();
            List<int> nOrdiniBibita = new List<int>();  //lista parallela a "bibiteOrdinate" per dire quante copie di quella bibita sono state ordinate

            int posizioneGustoNellOrdine = -1;
            int posizioneBibitaNellOrdine = -1;


            foreach (Ordine o in Ordini)
            {
                try
                {

                    if (o.Piz.Gusto2 == "")  //la pizza ha un gusto
                    {
                        posizioneGustoNellOrdine = CercaGustoNellaStampa(o.Piz.Gusto1, gustiOrdinati);
                    }
                    else        //la pizza ha due gusti
                    {
                        posizioneGustoNellOrdine = CercaGustoNellaStampa(o.Piz.Gusto1 + o.Piz.Gusto2, gustiOrdinati);
                    }

                }
                catch
                {
                    MessageBox.Show("Errore con la prima parte della funzione", "Errore");
                }

                try
                {
                
                    if (posizioneGustoNellOrdine == -1)    //l'ordine non è già presente nella stampa, equivale allo scrivere sul foglio delle ordinazioni il gusto che si vuole
                    {
                        if (o.Piz.Gusto2 == "")  //la pizza ha un gusto
                            gustiOrdinati.Add(o.Piz.Gusto1);
                        else
                            gustiOrdinati.Add(o.Piz.Gusto1 + o.Piz.Gusto2);

                        nOrdiniGusto.Add(1);
                        indGusti++;
                    }
                    else  //l'ordine è già presente nel foglio delle ordinazioni, equivale (nella realtà) ad aumentare il numero di volte che l'ordine già scritto viene richiesto
                    {
                        nOrdiniGusto[posizioneGustoNellOrdine]++;
                    }

                }
                catch
                {
                    MessageBox.Show("Errore con la seconda parte della funzione", "Errore");
                }

                //--- BIBITE

                try
                {
                    posizioneBibitaNellOrdine = CercaBibitaNellaStampa(o.Piz.Bibita, bibiteOrdinate);

                    if(posizioneBibitaNellOrdine == -1) //l'ordine non è già presente nella stampa, equivale allo scrivere sul foglio delle ordinazioni il gusto che si vuole
                    {
                        bibiteOrdinate.Add(o.Piz.Bibita);
                        nOrdiniBibita.Add(1);
                        indBibite++;
                    }
                    else  //l'ordine è già presente nel foglio delle ordinazioni, equivale (nella realtà) ad aumentare il numero di volte che l'ordine già scritto viene richiesto
                    {
                        nOrdiniBibita[posizioneBibitaNellOrdine]++;
                    }
                }
                catch
                {
                    MessageBox.Show("Errore con la prima parte della funzione", "Errore");
                }

            }

            gustiOrdinati.TrimExcess(); //tirare via lo spazio in più e guardare la capacità di quella lista equivale ad un .lenght non presente
            bibiteOrdinate.TrimExcess();

            ordineFinale = "A nome: " + txtNomeOrdine.Text + "\n";
            ordineFinale += "Scuola: " + txtScuolaOrdine.Text + "\n";
            ordineFinale += "Alle ore: " + txtOraOrdine.Text + "\n\n";

            try
            {
                ordineFinale += "PIZZE:\n";
                for (int i = 0; i < gustiOrdinati.Capacity; i++)
                {
                    ordineFinale += gustiOrdinati[i] + " X" + nOrdiniGusto[i] + "\n";
                }

            }
            catch
            {
                MessageBox.Show("Errore con la stampa delle pizze", "Errore");
            }
            
            try
            {

                ordineFinale += "\nBIBITE:\n";
                for (int i = 0; i < bibiteOrdinate.Capacity; i++)
                {
                    ordineFinale += bibiteOrdinate[i] + " X" + nOrdiniBibita[i] + "\n";
                }

            }
            catch
            {
                MessageBox.Show("Errore con la stampa delle bibite", "Errore");
            }

            MessageBox.Show(ordineFinale, "ORDINE");

        }

        //-------------------------------------------------------------------------------------------------------------------

        private void btnEliminaTuttiOrdini_Click(object sender, EventArgs e)
        {
            Ordini.Clear();
            dgvPizze.Rows.Clear();
            cmbGestPizze.Items.Clear();
        }

        //-------------------------------------------------------------------------------------------------------------------

    }
}
