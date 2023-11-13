using System;


public class Rechteck
{
    private float x;
    private float y;
    private float breite;
    private float höhe;

    public Rechteck(float x = 100.0f, float y = 100.0f, float breite = 2.0f, float höhe = 1.0f)
    {
        this.x = x;
        this.y = y;
        this.breite = breite;
        this.höhe = höhe;
    }

    public void ZeigePosition()
    {
        Console.WriteLine($"Position: ({x}, {y})");
    }

    public void ZeigeFläche()
    {
        double fläche = breite * höhe;
        Console.WriteLine($"Rechteckfläche: {fläche}");
    }

    public void Rotiere()
    {
        Console.WriteLine("Rechtecke können um 90° rotiert werden.");
    }
}
