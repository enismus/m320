class Program
{
    public static void Main(string[] args)
    {
        int val = 10;
        IncrementValue(val);
        Console.WriteLine(val);
    }

    public static void IncrementValue(int value)
    {
        value = value + 1;
    }
}