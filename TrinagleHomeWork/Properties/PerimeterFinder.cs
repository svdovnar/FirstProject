using System;

namespace TrinagleHomeWork
{
    public class PerimeterFinder
    {
        public void GetPerimeter(Square square)
        {
            Console.WriteLine($"Периметр квадрата: {square.GetPerimeter()}");
        }
        public void GetPerimeter(Circle circle)
        {
            Console.WriteLine($"Периметр круга: {circle.GetPerimeter()}");
        }

        public void GetPerimeter(Rectangle rectangle)
        {
            Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
        }

        public void GetPerimeter(Triangle triangle)
        {
            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
        }

        public void GetPerimeter(Polygon polygon)
        {
            Console.WriteLine($"Периметр многоугольника: {polygon.GetPerimeter()}");
        }
    }
}