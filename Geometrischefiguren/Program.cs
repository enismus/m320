using System;


class Program
{
    static void Main(string[] args)
    {
        List<GeometrischeFigur> figuren = new List<GeometrischeFigur>();

        figuren.Add(new Kreis(150.0f, 150.0f, 3.0f));
        figuren.Add(new Rechteck(200.0f, 200.0f, 4.0f, 2.0f));
        figuren.Add(new Dreieck(250.0f, 250.0f, 3.0f, 4.0f, 5.0f));
        figuren.Add(new Quadrat(300.0f, 300.0f, 2.0f));

        foreach (var figur in figuren)
        {
            figur.ZeigePosition();
            figur.ZeigeFläche();
            figur.Rotiere();
            Console.WriteLine();
        }
    }
}
