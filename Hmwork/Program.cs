using System;

namespace Hmwork
{
    internal class Program
    {
        public static void Main(string[] args)
        {Triangle MyTriangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(0, 5));
            Console.WriteLine( MyTriangle.SideAB.Lenght.ToString());
            Console.WriteLine( MyTriangle.GetAngleDegree( MyTriangle.AngleA ).ToString());
            Console.WriteLine("Rectangled? : " +  MyTriangle.Rectangled.ToString());
            Console.WriteLine("Perimeter : " +  Math.Round( MyTriangle.Perimeter, 2 ).ToString());
            Console.WriteLine("Area : " + Math.Round(MyTriangle.Area, 4).ToString());
            Console.WriteLine("Lenght of altitude for Side AB :" + MyTriangle.GetAltitudeLenght(MyTriangle.SideAB).ToString());
            Console.ReadLine();
        }
    }
}