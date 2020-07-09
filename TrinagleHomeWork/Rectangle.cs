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
        }
        public override float GetSquare()
        {
            float square = _sideA * _sideB;
            return square;
        }

        public float GetPerimeter()
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
}