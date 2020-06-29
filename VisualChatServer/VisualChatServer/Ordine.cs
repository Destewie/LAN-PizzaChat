using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualChatServer
{
    class Ordine
    {
        long numOrdine;
        Pizza piz;
        Utente ut;
        bool pagato = false ;

        public bool Pagato { get => pagato; set => pagato = value; }
        internal Pizza Piz { get => piz; set => piz = value; }
        internal Utente Ut { get => ut; set => ut = value; }
        public long NumOrdine { get => numOrdine; set => numOrdine = value; }

        //----------------------------------------------------------------------------------------

        public Ordine (long n, Pizza p, Utente u)
        {
            NumOrdine = n;
            piz = p;
            ut = u;
        }

        //----------------------------------------------------------------------------------------
    }
}
