using System;
using System.Runtime.InteropServices;

namespace Training
{
    class Programm
    {
        static int Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            StudentBase Baza = new StudentBase();
            Console.WriteLine("\n\n");
            for (int i = 0; i < Baza.studBase.GetLength(0); i++)
            {
                Console.WriteLine(Baza.studBase[i]);
            }

            Console.WriteLine("\n\n" + Baza[0]);
            Console.WriteLine(Baza[1] + "\n\n");

            Baza.accessibility = true;
            Console.WriteLine("Доступ : " + Baza.accessibility);
            Console.WriteLine("Кількість Нечаїв : " + Baza.surnameAmount() + "\n\n");

            Baza.accessibility = false;
            Console.WriteLine("Доступ : " + Baza.accessibility);
            Console.WriteLine("Кількість Нечаїв : " + Baza.surnameAmount());


            return 0;
        }
    }
}