using System;


public class Quadrat : Rechteck
{
    public Quadrat(float x = 100.0f, float y = 100.0f, float seitenlänge = 2.0f)
        : base(x, y, seitenlänge, seitenlänge)
    {
    }
}
