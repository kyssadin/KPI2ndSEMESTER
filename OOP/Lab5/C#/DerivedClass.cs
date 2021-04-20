using System;
using System.Linq;

namespace Lab5_OOP
{
    internal class dString : bString
    {
        internal dString(params string[] input) : base(input)
        {
            data = input;
        }
        
        public string[] getData() => data;
        
        public string this[int index]
        {
            get
            {
                try
                {
                    return data[index];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Index out of range.");
                    throw;
                }
            }
        }

        public void removeDigit(char digit)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    if (data[i][j] == digit)
                    {
                        data[i] = data[i].Remove(j, 1);
                        j--;
                    }
                    
                }
            }
        }
        
    }
}