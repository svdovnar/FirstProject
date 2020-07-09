using System;
using System.Data.SqlTypes;

namespace TrinagleHomeWork
{
    public class Square : Figure, IComparable, ICloneable
    {
        private int _squareLength;

        public Square(Point bottomLeftSquarePoint, int squareLength)
        {
            A = bottomLeftSquarePoint;
            B = new Point(bottomLeftSquarePoint.x + squareLength, bottomLeftSquarePoint.y);
            C = new Point(bottomLeftSquarePoint.x, bottomLeftSquarePoint.y + squareLength);
            D = new Point (bottomLeftSquarePoint.x + squareLength, bottomLeftSquarePoint.y + squareLength);
            _squareLength = squareLength;
        }

        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        // private double GetSideDA(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        // {
        //     var sum1 = Math.Pow(secondPointX - firstPointX, 2);
        //
        //     var sum2 = Math.Pow(secondPointY - firstPointY, 2);
        //
        //     return Math.Sqrt(sum1 + sum2);
        // }

        public override float GetSquare()
        {
            double result = _squareLength*2;
            return (float)result;
        }

        public override float GetPerimeter()
        {
            double result = _squareLength*4;
            return (float)result;
        }


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}