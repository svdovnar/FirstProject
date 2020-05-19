using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Random rand = new Random();
            students.Add(new Student("Увалера", rand));
            students.Add(new Student("Ванятка", rand));
            students.Add(new Student("Никита", rand));
            students.Add(new Student("Слава", rand));
            students.Add(new Student("Вова", rand));

            foreach (var student in students)
            {
                Console.Write($"{student.StudentName}");
                foreach (var studentMark in student.Marks)
                {
                    Console.Write($" {studentMark}");
                }

                Console.WriteLine();
            }

            int markSum = 0;
            foreach (var student in students)
            {
                for (int i = 0; i < student.Marks.Count; i++)
                {
                    markSum += student.Marks[i];
                }
            }

            Console.WriteLine($"Сумма оценок всех студентов: {markSum}");

            foreach (var student in students)
            {
                float sumOfMarks = 0;
                for (int i = 0; i < student.Marks.Count; i++)
                {
                    sumOfMarks += student.Marks[i];
                }

                float averageMark = sumOfMarks / student.Marks.Count;
                student.AverageMark = averageMark;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Ученик: {student.StudentName}, имеет среднюю оценку [{student.AverageMark}]");
            }

            var orderedStudents = students.OrderBy(st => st.AverageMark);

            foreach (var orderedStudent in orderedStudents)
            {
                Console.WriteLine(
                    $"Ученик: {orderedStudent.StudentName}, имеет среднюю оценку [{orderedStudent.AverageMark}]");
            }
        }
    }

    class Student
    {
        public Student(string studentName, Random rand)
        {
            StudentName = studentName;
            int randomNumber = 0;
            for (int i = 0; i < 5; i++)
            {
                int newMark;
                do
                {
                    newMark = rand.Next(1, 10);
                } while (newMark == randomNumber);

                randomNumber = newMark;

                Marks.Add(randomNumber);
            }
        }

        public string StudentName { get; set; }

        public List<int> Marks = new List<int>();
        public int SumMark { get; set; }
        public float AverageMark { get; set; }
    }
}