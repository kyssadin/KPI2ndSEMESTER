using System;

namespace Laba1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers you want to be compared\n");
            Console.WriteLine("1 > ");
            var a = Convert.ToInt32(Console.ReadLine()); // 1 chsilo sravneinya
            Console.WriteLine("2 > ");
            var b = Convert.ToInt32(Console.ReadLine()); // 2 chislo sravneniya
            Console.WriteLine(equality(a, b) ? "Numbers are equal" : "Numbers are not equal");
            Console.WriteLine("\n\n\nEnter the number to increment > ");
            var c = Convert.ToInt32(Console.ReadLine()); // increment chislo
            Increment(c, out var res);
            Console.WriteLine(res);
        }
        private static void Increment(int b, out int result)
        {
            int counter = 0;
            while ((b & (1 << counter)) != 0)
            {
                b = b ^ (1 << counter);
                counter++;
            }
            b = b ^ (1 << counter);
            result = b;
        }
        public static bool equality(int number1, int number2)
        {
            bool equal = true;
            for (int x = 0; ((x < sizeof(int) * 8) | (x < sizeof(int) * 8)); x++)
            {
                if ((number1 & (1 << x)) == (number2 & (1 << x)))
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                    return equal;
                }
            }
            return equal;
        }

    }
}