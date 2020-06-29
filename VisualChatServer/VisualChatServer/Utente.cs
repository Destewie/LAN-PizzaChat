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
    class Utente
    {
        long numUtente;
        Socket sock;
        string nomeUtente;
        bool attivo = true;

        public Socket Sock { get => sock; set => sock = value; }
        public string NomeUtente { get => nomeUtente; set => nomeUtente = value; }
        public bool Attivo { get => attivo; set => attivo = value; }
        public long NumUtente { get => numUtente; set => numUtente = value; }

        //---------------------------------------------------------------------------------------------------------------------

        public Utente(long n, Socket s, string nome)
        {
            NumUtente = n;
            sock = s;
            nomeUtente = nome;
        }

        //---------------------------------------------------------------------------------------------------------------------

    }
}
