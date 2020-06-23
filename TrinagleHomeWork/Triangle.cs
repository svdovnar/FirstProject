using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrinagleHomeWork
{
    public class Triangle
    {
        private double aX, aY, bX, bY, cX, cY;
        private double aB, bC, cA;

        public Triangle()
        {
            GetAllSides();
        }

        public Triangle(double aX, double aY, double bX, double bY, double cX, double cY)
        {
            this.aX = aX;
            this.bY = bY;
            this.aY = aY;
            this.cX = cX;
            this.bX = bX;
            this.cY = cY;
            GetAllSides();
        }

        public Triangle(Point A, Point B, Point C)
        {
            this.aX = A.x;
            this.bY = A.y;
            this.aY = B.x;
            this.cX = B.y;
            this.bX = C.x;
            this.cY = C.y;

            GetAllSides();
        }

        public double GetSideLength(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            var sum1 = Math.Pow(secondPointX - firstPointX, 2);

            var sum2 = Math.Pow(secondPointY - firstPointY, 2);

            return Math.Sqrt(sum1 + sum2);
        }

        public double GetSideBC()
        {
            return GetSideLength(bX,bY,cX,cY);
        }

        public double GetSideAB()
        {
            return GetSideLength(aX,aY,bX,bY);
        }

        public double GetSideCA()
        {
            return GetSideLength(aX,aY,cX,cY);
        }

        public double GetAngleA()
        {
            return Math.Acos((aB * aB + cA * cA - bC * bC) / (2 * aB * cA)) * 180 / Math.PI;
        }

        public double GetAngleB()
        {
            return Math.Acos((aB * aB + bC * bC - cA * cA) / (2 * aB * bC)) * 180 / Math.PI;
        }

        public double GetAngleC()
        {
            return Math.Acos((bC * bC + cA * cA - aB * aB) / (2 * bC * cA)) * 180 / Math.PI;
        }

        public double GetPerimeter()
        {
            GetAllSides();

            var perimeter = aB + bC + cA;

            return perimeter;
        }

        public double GetSquare()
        {
            GetAllSides();

            var halfOfPerimeter = GetPerimeter() / 2;

            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - aB) * (halfOfPerimeter - bC) * (halfOfPerimeter - cA));
        }

        private void GetAllSides()
        {
            aB = GetSideAB();
            bC = GetSideBC();
            cA = GetSideCA();
        }

        public override string ToString()
        {
            return $"{nameof(aX)}: {aX}, {nameof(aY)}: {aY}, {nameof(bX)}: {bX}, {nameof(bY)}: {bY}, {nameof(cX)}: {cX}, {nameof(cY)}: {cY}, {nameof(aB)}: {aB}, {nameof(bC)}: {bC}, {nameof(cA)}: {cA}";
        }
        
    }
}