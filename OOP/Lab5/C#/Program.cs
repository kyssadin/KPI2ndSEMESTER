using System;

namespace Lab5_OOP
{
    class Program
    {
        static void printStrings(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
        
        static void Main(string[] args)
        {
            var obj = new dString("This", "Cont4ins", "444 Fours");

            printStrings(obj.getData());

            Console.WriteLine($"Length of line 1 : {obj.getsLength(0)}");
            Console.WriteLine($"Length of line 2 : {obj.getsLength(1)}");
            Console.WriteLine($"Length of line 3 : {obj.getsLength(2)}");

            obj.removeDigit('4');
            
            printStrings(obj.getData());
            
            Console.WriteLine($"Length of line 2 : {obj.getsLength(1)}");
            Console.WriteLine($"Length of line 3 : {obj.getsLength(2)}");
        }
    }
}