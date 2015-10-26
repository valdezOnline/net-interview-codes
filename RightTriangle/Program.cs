using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace RightTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputChar = "";
            string inputRows = "";
            int numRows = 0;
            Console.Write("Enter the character to use: ");
            inputChar = Console.ReadLine();
            Console.Write("Enter the number of rows: ");
            inputRows = Console.ReadLine();
            if(int.TryParse(inputRows, out numRows ))
            {
                for (int i = 0; i <= numRows-1; i++)
                {
                    for (int j = numRows; j >= i; j--)
                    {
                        Console.Write(' ');
                    }
                    for (int x = 0; x <= i; x++)
                    {
                       Console.Write(inputChar);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
