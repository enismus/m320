
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            wasserfass meinWasserfass = new wasserfass(0, 100, 200);

            meinWasserfass.WasserHinzufügen(50);

           
            meinWasserfass.WasserEntnehmen(30);

          
            meinWasserfass.FassEntleeren();

           

            Console.ReadLine(); 
        }
    }
