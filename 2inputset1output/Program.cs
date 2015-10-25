using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2inputset1output
{
    class Program
    {
        static void Main(string[] args)
        {
            
            InputsCollection entries = new InputsCollection();
            
            // Enter first-set (Numbers Only):
            Console.WriteLine("Enter first-set (Numbers Only [positive/negative or decimals])...Enter 5 times");
                        
            for (int i = 0; i < 5; i++)
            {
                InputReceived entry = new InputReceived();
                string input = Console.ReadLine();
                if (entry.ValidateNbrInput(input))
                {
                    entry.dblValue = Convert.ToDouble(input);
                    entry.strValue = input;
                    entries.Add(entry);
                }
                else
                {
                    Console.WriteLine("Invalid Number Entered!");
                }
            }

            // Enter first-set (Letters Only):
            Console.WriteLine("Enter second-set (Letters Only [a-j])...Enter 5 times");

            for (int i = 0; i < 5; i++)
            {
                InputReceived entry = new InputReceived();
                string input = Console.ReadLine();
                if (entry.ValidateLtrInput(input))
                {
                    entry.dblValue = Convert.ToDouble(entry.ReturnLetterValue(input));
                    entry.strValue = input;
                    entries.Add(entry);
                }
                else
                {
                    Console.WriteLine("Invalid Letter Entered!");
                }
            }

            // Sort Entries
            var sortedEntries = from entry in entries
                                orderby entry.dblValue, entry.strValue
                                select entry.strValue;

            // Display Sorted Entries
            Console.WriteLine();
            Console.WriteLine("Sorted Output...");

            foreach (string msg in sortedEntries)
            {                
                Console.WriteLine(' ' + msg);
            }

            Console.ReadLine();
        }
    }
}
