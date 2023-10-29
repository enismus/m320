using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class wasserfass
{
    private int minimalPegel;
    private int maximalPegel;
    private int füllstand;
    private int kapazität;

    
    public wasserfass(int minPegel, int maxPegel, int kapazität)
    {
        minimalPegel = minPegel;
        maximalPegel = maxPegel;
        this.kapazität = kapazität;
        füllstand = minimalPegel;
    }

    
    public void WasserHinzufügen(int menge)
    {
        if (füllstand + menge <= kapazität)
        {
            füllstand += menge;
            Console.WriteLine("Wasser hinzugefügt. Aktueller Füllstand: " + füllstand);
        }
        else
        {
            Console.WriteLine("Das Wasserfass kann nicht mehr Wasser aufnehmen.");
        }
    }

    
    public void WasserEntnehmen(int menge)
    {
        if (füllstand - menge >= minimalPegel)
        {
            füllstand -= menge;
            Console.WriteLine("Wasser entnommen. Aktueller Füllstand: " + füllstand);
        }
        else
        {
            Console.WriteLine("Das Wasserfass kann nicht mehr Wasser entnehmen.");
        }
    }

   
    public void FassEntleeren()
    {
        füllstand = minimalPegel;
        Console.WriteLine("Das Fass wurde komplett entleert.");
    }
}
