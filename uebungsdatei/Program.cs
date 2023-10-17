using System;

class Program
{
    static void Main()
    {
        // Ganze Zahlen
        int myInteger = 42;
        short myShort = 10000;
        long myLong = 1234567890L;

        // Gleitkommazahlen
        float myFloat = 3.14f;
        double myDouble = 2.71828;

        // Booleans
        bool isTrue = true;
        bool isFalse = false;

        // Zeichen
        char myChar = 'A';

        // Zeichenketten
        string myString = "Hallo, Welt!";

        // Bytes
        byte myByte = 255;

        // Dezimalzahlen
        decimal myDecimal = 123.456m;

        Console.WriteLine("int: " + myInteger);
        Console.WriteLine("short: " + myShort);
        Console.WriteLine("long: " + myLong);
        Console.WriteLine("float: " + myFloat);
        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("bool (true): " + isTrue);
        Console.WriteLine("bool (false): " + isFalse);
        Console.WriteLine("char: " + myChar);
        Console.WriteLine("string: " + myString);
        Console.WriteLine("byte: " + myByte);
        Console.WriteLine("decimal: " + myDecimal);

        // Warte auf Benutzereingabe, damit das Konsolenfenster nicht sofort geschlossen wird
        Console.ReadLine();
    }
}
