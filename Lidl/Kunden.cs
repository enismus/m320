using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lidl
{
    internal class Kunden :Person
    {
        public double Umsatz { get; set; }
        public Kunden(string name, string vorname, int iDnumber, string key, double umsatz) : base(vorname, name,iDnumber,key)
        {
            Umsatz = umsatz;
        }
        public void Kaufe() 
        {
            Console.WriteLine("Ich als Kunde {0} {1} kaufe bei Lidl ein.", Name, Vorname);
        }
        public override void Trage()
        {
            Console.WriteLine("Ich als Kunde {0} {1} kaufe bei Lidl ein.", Name, Vorname);
        }
    }
}
