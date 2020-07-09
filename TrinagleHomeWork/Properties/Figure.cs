using System;

namespace TrinagleHomeWork
{
    public abstract class Figure
    {
        public int Point;
        public void PrintCoolText()
        {
            Console.WriteLine("This is figure.");
        }

        public abstract float GetSquare();

        public abstract float GetPerimeter();
    }
}