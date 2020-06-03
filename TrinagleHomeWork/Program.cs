using System;

namespace TrinagleHomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
           Triangle triangle = new Triangle();
           var sideAB = triangle.GetSideAB();
           Console.WriteLine(sideAB);
           var sideBC = triangle.GetSideBC();
           Console.WriteLine(sideBC);
           var sideCA = triangle.GetSideCA();
           Console.WriteLine(sideCA);
           var perimeter = triangle.GetPerimeter();
           Console.WriteLine(perimeter);
           var square = triangle.GetSquare();
           Console.WriteLine(square);
           var angleA = triangle.GetAngleA();
           Console.WriteLine(angleA);
        }
    }
}