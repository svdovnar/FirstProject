using System;

namespace TrinagleHomeWork
{
    public class Rectangle : Figure
    {
        private float _sideA;
        private float _sideB;

        public Rectangle(float sideA, float sideB)
        {
            _sideA = sideA;
            _sideB = sideB;

            pointPublic = 4;
        }
        public override float GetSquare()
        {
            float square = _sideA * _sideB;
            return square;
        }

        protected override void DoSomethingElse()
        {
            base.DoSomethingElse();
            Console.WriteLine("Now my logic works");
        }

        public override float GetPerimeter()
        {

            float perimeter = (_sideA +_sideB)*2;
            return perimeter;
        }

        public float GetDiagonal()
        {
            float diagonal = (float) Math.Sqrt((double) _sideA * _sideA + _sideB * _sideB);
            return diagonal;
        }
    }

    class ChildOfRectangle : Rectangle
    {
        public ChildOfRectangle(float sideA, float sideB, int c, int v) : base(sideA, sideB)
        {
        }

        public void SomethingThatOnlyChildCanDo()
        {

        }





        protected override void DoSomethingElse()
        {
            Rectangle rect = new ChildOfRectangle(5f,6f,5,3);

            base.DoSomethingElse();
        }
    }
}