using System;

public class Dreieck
{
    private float x;
    private float y;
    private float seitenlänge1;
    private float seitenlänge2;
    private float seitenlänge3;

    public Dreieck(float x = 100.0f, float y = 100.0f, float seitenlänge1 = 3.0f, float seitenlänge2 = 4.0f, float seitenlänge3 = 5.0f)
    {
        this.x = x;
        this.y = y;
        this.seitenlänge1 = seitenlänge1;
        this.seitenlänge2 = seitenlänge2;
        this.seitenlänge3 = seitenlänge3;
    }

    public void ZeigePosition()
    {
        Console.WriteLine($"Position des Dreiecks: ({x}, {y})");
    }

    public void ZeigeFläche()
    {
        Console.WriteLine("Flächenberechnung für Dreiecke wird hier nicht durchgeführt.");
    }

    public void Rotiere()
    {
        Console.WriteLine("Dreiecke können um 90 Grad im Uhrzeigersinn rotiert werden.");
    }
}
