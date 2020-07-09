using System;
using System.Collections.Generic;

namespace HomeWork_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public static class DisciplinesGenerator
    {
        private static string[] all = {"Mathematica","Chemistry","Biolagy", "Phisics"};
        public static string GetRandomDiscipline()
        {
            Random rand = new Random();
            var randIndex = rand.Next(0, all.Length);

            return all[randIndex];
        }
    }

    class Student
    {
        public string Name;

        public List<string> Disciplines  = new List<string>();



        public Dictionary<string, float> markByDiscipline = new Dictionary<string, float>();

        public void DoSomething()
        {
           var randomDiscipline = DisciplinesGenerator.GetRandomDiscipline();
        }
    }
}