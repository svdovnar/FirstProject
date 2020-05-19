using System;

namespace Stud
{
    class Student
        {
            private string name;
            private int ocenki;
            private double number;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Ocenki
            {
                get { return ocenki; }
                set { ocenki = value; }
            }

            public double Number
            {
                get { return number; }
                set { number = value; }
            }
            public void Print()
            {
                Console.WriteLine("Фамилия: " + Name);
                Console.WriteLine("Оценки студента: " + Ocenki);
                Console.WriteLine("Средний балл студента: " + Number);
                Console.WriteLine();
            }

            public void FillInfo()
            {
                Console.WriteLine("Введите фамилию студента: ");
                Name = Console.ReadLine();
                Console.WriteLine("Введите оценку студента (пример 1234): ");
                Ocenki = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите средний балл студента: ");
                Number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student FirstStudent = new Student();
                FirstStudent.FillInfo();
                Student SecondStudent = new Student();
                SecondStudent.FillInfo();
                Console.Clear();
                FirstStudent.Print();
                SecondStudent.Print();
            }
        }
}