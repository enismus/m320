namespace Assoziationen_uebung2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hund aron = new Hund();
           Hund dawud = new Hund();
           Laus lausi = new Laus(aron);
           Laus lausi2 = new Laus(dawud);


        }
    }
}