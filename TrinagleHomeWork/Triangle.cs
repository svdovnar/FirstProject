using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrinagleHomeWork
{
    public class Triangle
    {
        double x1, x2, x3, y1, y2, y3;
        double Perimeter;
        double Square;
        double AB, BC, CA;
        double AngleA, AngleB, AngleC;
        double p;

        public Triangle ()
        {
            x1 = 1;
            y1 = 3;
            x2 = 2;
            y2 = 4;
            x3 = 3;
            y3 = 2;
            
        }
        public Triangle (double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            
        }

        public double GetSideAB()
        {
            AB = Math.Sqrt(Math.Pow((y1 - x1), 2) + Math.Pow((y2 - x2), 2));
            return AB;
        }
        public double GetSideBC()
        {
            BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            return BC;
        }
        public double GetSideCA()
        {
            CA = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)); 
            return CA;
        }

        public double GetAngleA()
        {
            AngleA = Math.Acos((AB * AB + CA * CA - BC * BC) / (2 * AB * CA)) * 180 / Math.PI;
            return AngleA;
        }

        public double GetAngleB()
        {
            AngleB = Math.Acos((AB * AB + BC * BC - CA * CA) / (2 * AB * BC)) * 180 / Math.PI;
            return AngleB;
        }

        public double GetAngleC()
        {
            AngleC = Math.Acos((BC * BC + CA * CA - AB * AB) / (2 * BC * CA)) * 180 / Math.PI;
            return AngleC;
        }
        public double GetPerimeter()
        { 
            Perimeter = AB + BC + CA; 
            AB = Math.Sqrt(Math.Pow((y1 - x1), 2) + Math.Pow((y2 - x2), 2));
            BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            CA = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)); 
            return Perimeter;
        }
        public double GetSquare() 
        {
            AB = Math.Sqrt(Math.Pow((y1 - x1), 2) + Math.Pow((y2 - x2), 2));
            BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)); 
            CA = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)); 
            p = Perimeter / 2; 
            Square = Math.Sqrt(p*(p-AB)*(p-BC)*(p-CA)); 
            return Square;
        }
    } 
}
