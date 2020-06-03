using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrinagleHomeWork
{
    public class Triangle
    {
        double x1, X2, X3, Y1, Y2, Y3;

        double Square;
        double AB, BC, CA;

        public double Perimiter;
        public double Sqare;
        public Triangle()
        {
        }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.X3 = x3;
            this.Y3 = y3;


            Perimiter =  GetPerimeter();
            Sqare = GetSquare();

        }

        public Triangle(Dot A, Dot B, Dot C)
        {
            this.x1 = A.x;
            this.Y1 = A.y;
            this.X2 = B.x;
            this.Y2 = B.y;
            this.X3 = C.x;
            this.Y3 = C.y;

            Perimiter =  GetPerimeter();
            Sqare = GetSquare();
        }

        public double X1
        {
            get => x1;

            set
            {
                x1 = value;

                Perimiter =  GetPerimeter();
                Sqare = GetSquare();
            }
        }

        public double GetSideAB()
        {
            AB = Math.Sqrt(Math.Pow((Y1 - x1), 2) + Math.Pow((Y2 - X2), 2));
            return AB;
        }

        public double GetSideBC()
        {
            BC = Math.Sqrt(Math.Pow((X3 - X2), 2) + Math.Pow((Y3 - Y2), 2));
            return BC;
        }

        public double GetSideCA()
        {
            CA = Math.Sqrt(Math.Pow((X3 - x1), 2) + Math.Pow((Y3 - Y1), 2));
            return CA;
        }

        public double GetAngleA()
        {
            return Math.Acos((AB * AB + CA * CA - BC * BC) / (2 * AB * CA)) * 180 / Math.PI;
        }

        public double GetAngleB()
        {
            return Math.Acos((AB * AB + BC * BC - CA * CA) / (2 * AB * BC)) * 180 / Math.PI;
        }

        public double GetAngleC()
        {
            return Math.Acos((BC * BC + CA * CA - AB * AB) / (2 * BC * CA)) * 180 / Math.PI;
        }

        private double GetPerimeter()
        {
            GetAllSides();

            var perimeter = AB + BC + CA;

            return perimeter;
        }

        private double GetSquare()
        {
            GetAllSides();

            var p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
        }

        private void GetAllSides()
        {
            AB = GetSideAB();
            BC = GetSideBC();
            CA = GetSideCA();
        }

    }

    public class Dot
    {
        public float x;
        public float y;

        public Dot(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}