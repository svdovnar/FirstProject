using System.Collections.Generic;
using System.Net.Mime;

namespace ClassBasic
{
    public  class Student
    {
        public static string Name;

        protected string LastName;
        public int Age;
        public int CourseNumber;
        private List<Course> allSutdentCourcses = new List<Course>();
        public Dictionary<Course, int> marksByCourses;
        public float AvarageMark;
        private float result;

        private static List<Student> students = new List<Student>();

        public  Student(string name)
        {
            Name = name;

            students.Add(this);
        }




        public float ClculateAvarage()
        {
             float devideResult = result / marksByCourses.Count;

            return devideResult;
        }



        private void OutputData(int i)
        {
            Age += 5;
        }

        private int ClaculateAvarage(object data)
        {
            throw new System.NotImplementedException();
        }

        private object GetDataFromServer()
        {
            throw new System.NotImplementedException();
        }

        public void DismissStudent()
        {
            ///
        }

        public void UpdateCourses(Course botanic)
        {
            allSutdentCourcses.Add(botanic);
        }

        // private List<Course> courses;
        //
        // public List<Course> GetCourses()
        // {
        //     return courses;
        // }
        //
        // public void SetCourses(List<Course> value)
        // {
        //     courses = value;
        // }

        public List<Course> MarksByCourses { get; private set; }

        public List<Course> GetCourses()
        {
            MarksByCourses.Add(new Course("dqcwd"));
            return allSutdentCourcses;
        }

        public static List<Student> GetAllStudents()
        {
            return students;
        }
    }

    public class Course
    {
        public Course(string botanica)
        {
            throw new System.NotImplementedException();
        }
    }
}