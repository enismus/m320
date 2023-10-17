using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assoziationen_uebung3
{
    internal class Kunde
    {
        private List<Buch> buecher = new List<Buch>;
        public void Leiht(Buch buch)
        {
            buecher.Add(buch);
            buch.IstAusgeliehen = true;

        }

        public void Retourniert(Buch buch)
        {

        }


    }
}
