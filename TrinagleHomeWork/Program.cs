using System;

namespace TrinagleHomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
           Triangle triangle = new Triangle(1,1,3,1,1,3);

           //Console.WriteLine(pr);
           Console.WriteLine(triangle);
           Console.WriteLine($"Периметр: {triangle.GetPerimeter()}");
           Console.WriteLine($"Площадь: {triangle.GetSquare()}");
        }
    }
}