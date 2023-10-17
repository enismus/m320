using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assoziationen_uebung2
{
    internal class Laus
    {
        private Hund wirt;

        public Laus(Hund wirt)
        {
            this.wirt = wirt;
            wirt.AddLaus(this);

        }
    }
}
