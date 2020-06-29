using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualChatServer
{
    class Pizza
    {
        private string gusto1;
        private string gusto2;
        private string bibita;

        public string Gusto1 { get => gusto1; set => gusto1 = value; }
        public string Gusto2 { get => gusto2; set => gusto2 = value; }
        public string Bibita { get => bibita; set => bibita = value; }

        //----------------------------------------------------------------------------------------

        public Pizza (string g1, string g2, string b)
        {
            gusto1 = g1;
            gusto2 = g2;
            bibita = b;
        }

        //----------------------------------------------------------------------------------------

    }
}
