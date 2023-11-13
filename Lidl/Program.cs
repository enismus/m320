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

            List<Person> person = new List<Person>() ;
            person.Add(kunde1);
            person.Add(lagerist1);
            person.Add(kind1);

            foreach (Person persons in person)
            {
                persons.Esse();
                persons.Trage();
               
            }
            Console.ReadLine();
            //kunde1.Esse();
            //kunde1.Kaufe();
            //kunde1.Trage();
            //lagerist1.Trage();
            //lagerist1.Esse();
            //lagerist1.LagereEin();
            //kind1.Esse();
            //kind1.Trage();
        }
    }
}