using System;
using System.Runtime.InteropServices;

namespace TrinagleHomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Triangle triangle = new Triangle(1, 2, 1, 3, 1, 4);

            Triangle triangle1 = new Triangle();
            Point bottomLeftSquarePoint = new Point(1, 1);
            Square square = new Square(bottomLeftSquarePoint, 2);
            Console.WriteLine(square.A);
            Console.WriteLine(square.B);
            Console.WriteLine(square.C);
            Console.WriteLine(square.D);
            Console.WriteLine($"Площадь квадрата: {square.GetSquare()}");
            Console.WriteLine($"Периметр квадрата: {square.GetPerimeter()}");
            float radius = 5f;
            Circle circle = new Circle(bottomLeftSquarePoint, radius);
            Console.WriteLine($"Площадь круга: {circle.GetSquare()}");
            Console.WriteLine($"Периметр круга: {circle.GetPerimeter()}");

            Point somePoint = new Point(2, 5);
            bool pointInsideCircle = circle.IsPointInside(somePoint);
            if (pointInsideCircle)
            {
                Console.WriteLine($"Точка {somePoint} находится внутри круга {circle}");
            }
            else
            {
                Console.WriteLine($"Точка {somePoint} находится вне круга {circle}");
            }

            // var pr = triangle1.Perimiter;
            //
            // triangle1.X1 = 3;
            //
            // var sq =  triangle1.Sqare;
            //
            //
            // var x1 = triangle.X1;
        }
    }

    internal class Circle
    {
        public Circle(Point bottomLeftSquarePoint, float radius)
        {
            throw new NotImplementedException();
        }

        public float GetSquare()
        {
            return 0;
        }

        public float GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public bool IsPointInside(Point somePoint)
        {
            throw new NotImplementedException();
        }
    }
}