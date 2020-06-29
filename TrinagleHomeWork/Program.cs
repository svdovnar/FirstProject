﻿using System;
using System.Runtime.InteropServices;

namespace TrinagleHomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Triangle triangle = new Triangle(1, 1, 1, 3, 4, 1);

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
            Circle circle = new Circle(bottomLeftSquarePoint, 5);
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


            Polygon polygon = new Polygon( 6, 5);
            Console.WriteLine($"Площадь многоугольника: {polygon.GetSquare()}");
            Console.WriteLine($"Периметр многоугольника: {polygon.GetPerimeter()}");
            Console.WriteLine($"Радиус вписанной окружности: {polygon.GetRadius()}");

            
            SqareFinder sqareFinder = new SqareFinder();

            sqareFinder.GetSqare(square);
            sqareFinder.GetSqare(circle);
            sqareFinder.GetSqare(rectangle);
            sqareFinder.GetSqare(triangle);
            sqareFinder.GetSqare(polygon);
            
            
            PerimeterFinder perimeterFinder = new PerimeterFinder();

            perimeterFinder.GetPerimeter(square);
            perimeterFinder.GetPerimeter(circle);
            perimeterFinder.GetPerimeter(rectangle);
            perimeterFinder.GetPerimeter(triangle);
            perimeterFinder.GetPerimeter(polygon);
            
            
            
            
            
            // sqareFinder.GetSqare(circle);
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
}