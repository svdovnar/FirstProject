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

            Point somePoint = new Point(2, 6);
            bool pointInsideCircle = circle.IsPointInside(somePoint);

            if (pointInsideCircle)
            {
                Console.WriteLine($"Точка {somePoint} находится внутри круга {circle}");
            }
            else
            {
                Console.WriteLine($"Точка {somePoint} находится вне круга {circle}");
            }

            float sideA = 4f;
            float sideB = 8f;
            Rectangle rectangle = new Rectangle(sideA, sideB);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetSquare()}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
            Console.WriteLine($"Диагональ прямоугольника: {rectangle.GetDiagonal()}");

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
        private float _radius;
        private Point _center;

        public override string ToString()
        {
            return $"{nameof(_radius)}: {_radius}, {nameof(_center)}: {_center}";
        }

        public Circle(Point bottomLeftSquarePoint, float radius)
        {
            _center = bottomLeftSquarePoint;
            _radius = radius;
        }

        public float GetSquare()
        {
            // S = pR^2;
            float S = (float) Math.PI * _radius * _radius;
            return S;
        }


        public float GetPerimeter()
        {
            //P = 2pR
            float P = 2 * (float) Math.PI * _radius;
            return P;
        }

        public bool IsPointInside(Point somePoint)
        {
            float distanceFromCenterToPoint = somePoint.GetDistance(_center);
            if (distanceFromCenterToPoint < _radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}