using System.Collections.Generic;

namespace Primitives_1
{
    internal class PrimitivesCollection
    {
        //ЗНАЧЕМЫЕ 
        enum MyEnum
        {
            day1,
            day2,
            day3
        }

        struct MyStruct
        {
        }

        //ССЫЛОЧНЫЕ
        class MyClass
        {
        }

        interface IMyInterface
        {
        
        }
    
        delegate void MyDelegate();
        public static void Main(string[] args)
        {
            //Ссылочные типы данных:
            MyClass cls1, cls2, cls3;
            object o1, o2, o3;
            string st1, st2, st3;
            IMyInterface intrf1, intrf2, intrf3;
            List<object> list1, list2, list3; // array, Dictionary<key,value>, IEnumerable<>, Queue<>.....
            MyDelegate dl1, dl2, dl3;
        
            //Значимые типы данных:
            int i1, i2, i3; //uint, short, long, ulong, ushort,sbyte
            float f1, f2, f3;
            decimal d1, d2, d3;
            char ch1, ch2, ch3;
            bool bl1, bl2, bl3;
            MyEnum en1, en2, en3;
            MyStruct str1, str2, str3;
        }
    }
}