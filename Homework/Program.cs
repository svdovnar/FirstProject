using System;

namespace Homework
{
    public enum Food
    { 
        Tuna,
        Salmon,
        Pizza,
        Spagetti,
        Salad,
        Tomatoes
    }

    public class EnumTry
    {
        public static void Main()
        {
            Food food = (Food) (new Random()).Next(0, 5);

            if (food == Food.Tuna)
            {
                Console.WriteLine("Ешь тунца");
            }
            else if (food == Food.Salmon)
            {
                Console.WriteLine("Ешь лосось");
            }
            else if (food == Food.Pizza)
            {
                Console.WriteLine("Ешь пиццу");
            }
            else if (food == Food.Spagetti)
            {
                Console.WriteLine("Ешь спагетти");
            }
            else if (food == Food.Salad)
            {
                Console.WriteLine("Ешь салат");
            }
            else
            {
                Console.WriteLine("Нихуя не ешь");
            }
        }

    }
 
}