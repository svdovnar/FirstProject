using System;

namespace TrinagleHomeWork
{
    public class PerimeterLogger
    {
        //open closed priciple
        public void OutputPerimeter(Figure figure)
        {
            Console.WriteLine($"Периметр фигуры равен: {figure.GetPerimeter()}");
        }
    }
}