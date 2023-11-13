using System;

public class Kreis
{
    private float x;
    private float y;
    private float radius;

    public Kreis(float x = 100.0f, float y = 100.0f, float radius = 1.0f)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public void ZeigePosition()
    {
        Console.WriteLine($"Position: ({x}, {y})");
    }

    public void ZeigeFläche()
    {
        double fläche = Math.PI * radius * radius;
        Console.WriteLine($"Kreisfläche: {fläche}");
    }

    public void Rotiere()
    {
        Console.WriteLine("Kreise können nicht rotiert werden.");
    }
}
