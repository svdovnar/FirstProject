using System;
using System.Collections.Generic;

namespace ClassBasic
{
    internal class Program
    {
        private int progrumNumber;
        public static void Main(string[] args)
        {
            Student vasya;

            
            var students = Student.GetAllStudents();
            vasya = new Student("Vasya");

            vasya.Age = 18;
            //vasya = "Vsya";

            vasya.UpdateCourses(new Course("Botanica"));
            var listOfVasyasCources = vasya.MarksByCourses;
            //vasya.MarksByCourses = new List<Course>();
            //vasya.allSutdentCourcses.Clear();


            float avarageMarkOfVasya = vasya.ClculateAvarage();

        }
    }
}