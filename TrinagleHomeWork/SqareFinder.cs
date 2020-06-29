using System;

namespace TrinagleHomeWork
{
    public class SqareFinder
    {
        public void GetSqare(Square square)
        {
            Console.WriteLine($"Прощадь квадрата: {square.GetSquare()}");
        }

        public void GetSqare(Circle circle)
        {
            Console.WriteLine($"Прощадь круга: {circle.GetSquare()}");
        }

        public void GetSqare(Rectangle rectangle)
        {
            Console.WriteLine($"Прощадь прямоугольника: {rectangle.GetSquare()}");
        }

        public void GetSqare(Triangle triangle)
        {
            Console.WriteLine($"Прощадь треугольника: {triangle.GetSquare()}");
        }

        public void GetSqare(Polygon polygon)
        {
            Console.WriteLine($"Прощадь многоугольника: {polygon.GetSquare()}");
        }
    }
}