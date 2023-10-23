namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person() { Name = "Efe", Vorname = "Bora" };
            Kunden kunde1 = new Kunden("Efe", "Atatuerk", 12, "Fener120", 1200000) ;
            Lagerist lagerist1 = new Lagerist("Abel", "Solomon", 7, "Lebron2005", 1.85);
            Kind kind1 = new Kind("Amandela", "Tomate", 15, "Italiennord1", 15);
            //person1.Esse();
            kunde1.Esse();
            kunde1.Kaufe();
            kunde1.Trage();
            lagerist1.Trage();
            lagerist1.Esse();
            lagerist1.LagereEin();
            kind1.Esse();
            kind1.Trage();
        }
    }
}