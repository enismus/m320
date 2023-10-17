using System;
using System.Collections.Generic;

// Erstellen der Klasse 'Fussballmannschaft'
public class Fussballmannschaft
{
    public string Name { get; }

    public Fussballmannschaft(string name)
    {
        Name = name;
    }

    public int Spielzug()
    {
        // Hier wird der Spielzug für die Mannschaft durchgeführt.
        // Vereinfacht wird nur eine zufällige Anzahl von Toren zurückgegeben.
        Random random = new Random();
        int erzielteTore = random.Next(0, 6); // Zufällige Anzahl von Toren zwischen 0 und 5.
        return erzielteTore;
    }
}

// Erstellen der Klasse 'Spiel'
public class Spiel
{
    public List<Fussballmannschaft> Mannschaften { get; } = new List<Fussballmannschaft>();

    public void FuehreSpielDurch()
    {
        Console.WriteLine("Spiel gestartet!");
        int toreMannschaft1 = Mannschaften[0].Spielzug();
        int toreMannschaft2 = Mannschaften[1].Spielzug();
        Console.WriteLine($"Spiel beendet!");

        Console.WriteLine($"{Mannschaften[0].Name} hat {toreMannschaft1} Tore erzielt.");
        Console.WriteLine($"{Mannschaften[1].Name} hat {toreMannschaft2} Tore erzielt.");
    }
}

class Program
{
    static void Main()
    {
        // Instanziieren von zwei Fussballmannschaften
        Fussballmannschaft mannschaft1 = new Fussballmannschaft("Mannschaft 1");
        Fussballmannschaft mannschaft2 = new Fussballmannschaft("Mannschaft 2");

        // Instanziieren eines Spiels und Hinzufügen der Mannschaften zum Spiel
        Spiel spiel = new Spiel();
        spiel.Mannschaften.Add(mannschaft1);
        spiel.Mannschaften.Add(mannschaft2);

        // Das Spiel wird durchgeführt
        spiel.FuehreSpielDurch();
    }
}
