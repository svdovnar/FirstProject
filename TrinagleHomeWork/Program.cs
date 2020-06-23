using System;

namespace TrinagleHomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
           Triangle triangle = new Triangle(1,1,3,1,1,3);

           Console.WriteLine(triangle);
           Console.WriteLine($"Периметр: {triangle.GetPerimeter()}");
           Console.WriteLine($"Площадь: {triangle.GetSquare()}");

           Point leftBotPoint = new Point(1, 1);

           Sqare sqare = new Sqare(leftBotPoint, 2);

           Console.WriteLine(sqare.B); // Coordinates: [1,4]




        }
    }
}