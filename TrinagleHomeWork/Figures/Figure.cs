using System;

namespace TrinagleHomeWork
{
    public abstract class Figure
    {
        private int pointPrivate = 5;
        public int pointPublic = 5;
        protected int pointProtected = 10;
        public void PrintCoolText()
        {
            Console.WriteLine("This is figure.");
        }

        private void DoSomething()
        {

        }


        protected virtual void DoSomethingElse()
        {
            DoSomething();
        }

        public abstract float GetSquare();

        public abstract float GetPerimeter();
    }
}