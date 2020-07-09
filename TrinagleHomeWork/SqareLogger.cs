using System;

namespace TrinagleHomeWork
{
    public class SqareLogger 
    {
        public void OutputSqare(Figure figure)
        {
            Console.WriteLine($"Периметр фигуры равен: {figure.GetSquare()}");
        }

    }
}