using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    class Options
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app
            Console.WriteLine("Razer Blue Technical Test\r");
            Console.WriteLine("-------------------------\n");

            while (!endApp)
            {
                // Ask the user to choose an operator
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 - Anagram Comparison");
                Console.WriteLine("\t2 - IPv4");
                Console.WriteLine("\t3 - Worst Fizz Buzz implementation");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing
            }
            return;
        }
    }
}
