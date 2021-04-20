using System;
using myStringLib;

namespace lab2
{
    internal static class Program
    {
        private static void Render(ref Text obj)
        {
            for (var k = 0; k < 3; k++){
                for (var i = 0; i < obj.Rows[k].rSize; i++)
                    Console.Write(obj.Rows[k].data[i]);
                Console.WriteLine();
            }
        }
        
        internal static void Main(string[] args)
        {
            var myStr = new Text(5);
            for (var i = 0; i < 5; i++)
            {
                myStr.Rows[i] = new RowContainer();
            }
            myStr.addRow("Hello".ToCharArray());
            myStr.addRow("Next is digits".ToCharArray());
            myStr.addRow("123456789".ToCharArray());
            myStr.addRow("Goodbye".ToCharArray());
            Console.WriteLine("========STARTING TEXT========");
            Render(ref myStr);
            Console.WriteLine();
            
            Console.WriteLine("========CALCULATIONS========");
            Console.WriteLine("Amount of characters in the text : " + myStr.getCharAmount());
            Console.WriteLine("Amount of digits in the text : " + myStr.getDigAmount());
            Console.WriteLine("Percentage of digits  : " + Math.Round(myStr.getDigPercentage(), 3) + "%");
            Console.Write("Max Row : ");
            for ( int i = 0 ; i < myStr.Rows[myStr.getMaxRow()].rSize; i++)
            {
                Console.Write(myStr.Rows[myStr.getMaxRow()].data[i]);
            }
            Console.WriteLine();
            
            Console.WriteLine("========ERASING TEXT========");
            Console.WriteLine("Row 1 deleted : ");
            myStr.delRow(1);
            Render(ref myStr);
            Console.WriteLine();
            Console.WriteLine("Everything deleted : ");
            myStr.erRows();
            Render(ref myStr);
            Console.WriteLine();
            
            }
        }
    }