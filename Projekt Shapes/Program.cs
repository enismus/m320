using System;

namespace Projekt_Shapes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 8;
            Console.WriteLine(rectangle.Height);
            rectangle.topLeftPoint = new PointD(0, rectangle.Height);
            rectangle.TopRightPoint = new PointD(9, rectangle.Height);
            Console.WriteLine($"rectangle width: {rectangle.width}");
            Console.WriteLine($"rectangle width: {rectangle.width}");
            Console.WriteLine($"rectangle width: {rectangle.width}");

        }
    }
}



