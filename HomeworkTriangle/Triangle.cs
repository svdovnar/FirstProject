using System;

namespace ConsoleApplication3
{
    public class Triangle
    {
        public double x1 { get; private set; }
        public double y0 { get; private set; }
        public double AB { get; private set; }
        public double AC { get; private set; }
        public double BC { get; private set; }
        public double square { get; private set; }
        public double perimeter { get; set; }
        public double angleA { get; private set; } 
        public double angleB { get; private set; }
        public double angleC { get; private set; }
        public string type { get; private set; }
 
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            AB = GetSideAB(x1, y1, x2, y2);
            BC = GetSideBC(x2, y2, x3, y3);
            AC = GetSideAC(x3, y3, x1, y1);
            angleA = GetAngleA(AB, BC, AC);
            angleB = GetAngleB(AB, BC, AC);
            angleC = GetAngleC(AB, BC, AC);
            type = GetType(AB, BC, AC);
        }
        static double GetSideAB(double x1, double y1, double x2, double y2) 
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
 
        static double GetSideBC(double x1, double y1, double x3, double y3) 
        {
            return Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        }
 
        static double GetSideAC(double x3, double y3, double x2, double y2) 
        {
            return Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        }
        
        private double GetPerimeter(double AB, double BC, double AC) 
        {
            return AB + BC + AC;
        }
 private double GetAngleA(double AB, double BC, double AC) 
        {
            return Math.Acos((AB * AB + AC * AC - BC * BC) / (2 * AB * AC)) * 180 / Math.PI;
        }
 
        private double GetAngleB(double AB, double BC, double AC) 
        {
            return Math.Acos((AB * AB + BC * BC - AC * AC) / (2 * AB * BC)) * 180 / Math.PI;
        }
 
        private double GetAngleC(double AB, double BC, double AC) 
        {
            return Math.Acos((BC * BC + AC * AC - AB * AB) / (2 * BC * AC)) * 180 / Math.PI;
        }
        
        private string GetType(double AB, double BC, double AC)
        {
            if (AB < BC + AC && BC < AB + AC && AC < AB + BC)
            { 
                if (AB == BC && BC == AC)
                    return "Равносторонний";
                else if (AB == BC || AB == AC || BC == AC)
                    return "Равнобедренный";
            }
            return "Разносторонний";
        }
    }
 
}