using System;

namespace TrinagleHomeWork
{
    public class PerimeterLogger
    {
        //open closed priciple
        public void OutputPerimetere(Square square)
        {
            Console.WriteLine($"Периметр квадрата: {square.GetPerimeter()}");
        }
        public void OutputPerimetere(Circle circle)
        {
            Console.WriteLine($"Периметр круга: {circle.GetPerimeter()}");
        }

        public void OutputPerimetere(Rectangle rectangle)
        {
            Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
        }

        public void OutputPerimetere(Triangle triangle)
        {
            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
        }

        public void OutputPerimetere(Polygon polygon)
        {
            Console.WriteLine($"Периметр многоугольника: {polygon.GetPerimeter()}");
        }
    }
}