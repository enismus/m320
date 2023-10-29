
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Wasserfasses mit den Mindest- und Höchstpegeln und der Kapazität
            wasserfass meinWasserfass = new wasserfass(0, 100, 200);

            // Wasser hinzufügen
            meinWasserfass.WasserHinzufügen(50);

            // Wasser entnehmen
            meinWasserfass.WasserEntnehmen(30);

            // Wasserfass komplett entleeren
            meinWasserfass.FassEntleeren();

            // Weitere Aktionen durchführen, falls gewünscht

            Console.ReadLine(); // Warten, damit das Konsolenfenster nicht sofort schließt
        }
    }
