using System;
using System.Runtime.InteropServices;

namespace Homework
{
    
}
public static class Kata
{
    public static string AbbrevName(string name)
    {
        if (name.Length == 0)
        {
            return name;
        }
        //Console.Write(Char.ToUpper(name[0]));
        for (int i = 1; i < name.Length - 1; i++)
        {
           // if (name[i] == ' ')
            //Console.Write("." + Char.ToUpper(name[i + 1]));
        }
        return name;
    }
    public static void Main()
    {
        string name = "Sam Harris";
        var result = AbbrevName(name);
        Console.WriteLine(result);
    }
}