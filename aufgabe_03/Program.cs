using System;

namespace Calculator
{
    class Program
    {
        static int lastResult = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");

            while (true)
            {
                Console.WriteLine("Choose your option-->");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.Write("Enter a number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            result = lastResult;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        continue;
                }

                lastResult = result;
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
