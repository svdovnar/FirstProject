using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Primitives_1
{
    internal class PrimitivesCollection
    {
        //ЗНАЧЕМЫЕ 
        enum DaysOfMyWeek
        {
            Monday, //0
            Fridsay, // 1
            Thirsday // 2
            
            // "1 2 3 4", "Mondey" , Enum DaysOfMyWeek.
        }

        struct MyStruct
        {
            public int age;
            public string Name;
            public int[] ocenki;
        }

        //ССЫЛОЧНЫЕ
        class Student
        {
            public int age;
            public string Name;
            
            public int[] ocenki; //1 - 10
            
            public float number = 1; 

            public override string ToString()
            {
                return number.ToString();
            }

            public Student Plus(Student newValue)
            {
                number = newValue.number;
                return this;
            }
            
        }

        interface IMyInterface
        {
        
        }

        public static int i1;
        delegate void MyDelegate();
        public static void Main(string[] args)
        {
            //Значимые типы данных:
            int  i2, i3; //uint, short, long, ulong, ushort,sbyte
           
            i1 = 1;//1
            i2 = 2;//3
            i3 = 3;//3
            
            //i3+1
            //i3 + i2;
            //var result1 = i3 / 5;
            Console.WriteLine($"i1: {i1} i2: {i2} i3: {i3}");
            i2 = i3;
            //Console.WriteLine(result1);
            
            //
            var result =  i1 / i2;
            // result = k / n 0.5 0.44 0.5212 0 1
            // 1/2 = 2/1 = 2 3/2 = 1
            //Devide(int, int) float 1.0 == int 1
            //+ - / * > < ==   i1 / i2 (int) / (int) => (int) ++ -- += -= *= 
            // a++
            // a = a + 1;
            // a+=11;
            // a = a + 11;
            // a /= b;
            // a = a / b;
            float f1, f2, f3;
            f1 = 1.2f;
            
                
            //Поиграться с операциями
            
            decimal d1, d2, d3;
            d1 = 5m;
            //Поиграться с операциями
            char ch1, ch2, ch3;
            ch1 = 'n'; // index n
            ch1 = 'c'; // 
            ch2 = 'b';
            //Поиграться с операциями
            Console.WriteLine(ch1 + ch2);
            
            bool isEnabled, bl2, bl3;
            
            DaysOfMyWeek en1, en2, en3;
            //Поиграться с операциями, написать свой енам, сделать экземпляр этого инама, и 
            //попробовать провести проверку в конструкции if с инамом
        
            en1 = DaysOfMyWeek.Monday;
            MyStruct str1, str2, str3;
            
            str1 = new MyStruct();
            
            //Ссылочные типы данных:
            Student cls1, cls2, cls3; 
            cls1 = new Student();
            //Сам создай 5 учеников, придумай им имена и оценки
            //Сложи всех созданных учеников в List 
            
            //посчитайть сумму оценок Student у 5 учеников у всех по 5 оценак, выведи в консоль
            
            
            //У каждого из них, number это их средняя успеваемость
            
            //Отсортируй по средней List используй для этого метод .OrderBy(e=>e.number).ToList();
            
            cls1.age = 3;
            cls1.number = 2;
            
            cls2 = new Student();
            cls2.number = 5;
            
            Console.WriteLine($"{cls1} {cls2}");
            cls1 = cls2;
            Console.WriteLine($"{cls1} {cls2}");
            cls2.number = 11;
            Console.WriteLine($"{cls1} {cls2}");
            
            object o1, o2, o3;
            
            Uchenik vasya = new Uchenik();

            Uchenik[] vseStudenti = new Uchenik[3000];

            for (int i = 0; i < vseStudenti.Length; i++)
            {
                vseStudenti[i] = new Uchenik();
            }

            List<Uchenik> vseStudentiList = new List<Uchenik>();
            
            foreach (var VARIABLE in vseStudenti)
            {
                vseStudentiList.Add(VARIABLE);
            }
                
            Dictionary<int,Uchenik> vseStudentiDictionary = new Dictionary<int,Uchenik>();
            
            string st1, st2, st3;
            st1 = "dwqcdqw";
            
            st2 = "qwdcqwcdqw";
            
            st1 = st2;
            
            
            IMyInterface intrf1, intrf2, intrf3;
            
            int[] dd = new int [3];
            
            List<object> list1, list2, list3; // array, Dictionary<key,value>, IEnumerable<>, Queue<>.....
           
            MyDelegate dl1, dl2, dl3;
        }
    }

    internal class Uchenik
    {
        
    }
}