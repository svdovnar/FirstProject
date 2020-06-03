using System;

namespace TrinagleHomeWork
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
           Triangle triangle = new Triangle(1,2,1,3,1,4);


           Triangle triangle1 = new Triangle();


           var pr = triangle1.Perimiter;

           triangle1.X1 = 3;

           var sq =  triangle1.Sqare;


           var x1 = triangle.X1;

        }
    }
}