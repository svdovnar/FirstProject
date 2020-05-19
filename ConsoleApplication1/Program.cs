using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<students> list = new List<students>();
            Random rand = new Random();
            list.Add(new students() { name = "Увалера", firstMark = rand.Next(1, 5), secondMark = rand.Next(1, 5), thirdMark = rand.Next(1, 5), forthMark = rand.Next(1,5), fifthMark = rand.Next(1,5) });
            list.Add(new students() { name = "Ванятка", firstMark = rand.Next(1, 5), secondMark = rand.Next(1, 5), thirdMark = rand.Next(1, 5) , forthMark = rand.Next(1,5), fifthMark = rand.Next(1,5)});
            list.Add(new students() { name = "Славон", firstMark = rand.Next(1, 5), secondMark = rand.Next(1, 5), thirdMark = rand.Next(1, 5) , forthMark = rand.Next(1,5), fifthMark = rand.Next(1,5)});
            list.Add(new students() { name = "Никитос", firstMark = rand.Next(1, 5), secondMark = rand.Next(1, 5), thirdMark = rand.Next(1, 5) , forthMark = rand.Next(1,5), fifthMark = rand.Next(1,5)});
            list.Add(new students() { name = "Вован", firstMark = rand.Next(1, 5), secondMark = rand.Next(1, 5), thirdMark = rand.Next(1, 5), forthMark = rand.Next(1,5), fifthMark = rand.Next(1,5)});
            
            List<students> newList = new List<students>();
            foreach(var item in list)
            {
                double number = ((double)item.firstMark + (double)item.secondMark + (double)item.thirdMark + (double)item.forthMark + (double)item.fifthMark) / 5;
                int sum = ((int)item.firstMark + (int)item.secondMark + (int)item.thirdMark + (int)item.forthMark + (int)item.fifthMark);
                newList.Add(new students() { name = item.name, srMark = number, sumMark = sum });
                Console.WriteLine(item.name + " " + item.firstMark + " " + item.secondMark + " " + item.thirdMark + " " + item.forthMark + " " + item.fifthMark + ". Сумма оценок = {0:0}", sum);
            }
            newList = newList.OrderBy(o => o.srMark).ToList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(newList[i].name + " " + newList[i].srMark);
            }
            Console.ReadLine();
        }
    }
    class students
    {
        public string name { get; set; }
        public int firstMark { get; set; }
        public int secondMark { get; set; }
        public int thirdMark { get; set; }
        public int forthMark { get; set; }
        public int fifthMark { get; set; }
        public int sumMark { get; set; }
        public double srMark { get; set; }
    }
}