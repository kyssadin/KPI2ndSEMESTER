using System;

namespace Lab5_OOP
{
    internal class bString
    {
        protected string[] data { get; set; }

        internal bString(params string[] input)
        {
            data = input;
        }

        public int getsLength(int index)
        {
            if ((index < 0) || (index > data.Length))
            {
                Console.WriteLine("Index out of range.");
                return -1;
            }

            return data[index].Length;
        }

        public int getLength() => data.Length;
    }
}