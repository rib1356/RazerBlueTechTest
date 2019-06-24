using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    class Options
    {
        public static Boolean anagramComparison(string a1, string a2)
        {
            //Convert both strings to lowercase
            char[] charArr1 = a1.ToLower().ToCharArray();  
            char[] charArr2 = a2.ToLower().ToCharArray();

            Array.Sort(charArr1);
            Array.Sort(charArr2);

            string newWord1 = new string(charArr1);  
            string newWord2 = new string(charArr2);

            if(newWord1 == newWord2)
            {
                return true;
            } else
            {
                return false;
            }
        }
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
                string anagram1 = "";
                string anagram2 = "";

                // Ask the user to choose an operator
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 - Anagram Comparison");
                Console.WriteLine("\t2 - IPv4");
                Console.WriteLine("\t3 - Worst Fizz Buzz implementation");
                Console.Write("Your option? ");

                switch(Console.ReadLine())
                {
                    case "1":
                      Console.Write("Type , and then press Enter: ");
                      anagram1 = Console.ReadLine();

                      Console.Write("Type a second number, and then press Enter: ");
                      anagram2 = Console.ReadLine();

                      Console.WriteLine("------------------------\n");

                      Console.WriteLine(Options.anagramComparison(anagram1, anagram2));
                      //Console.WriteLine(blah);
                      break;
                    case "2":
                        Console.WriteLine("2 pressed");
                      break;
                    case "3":
                        Console.WriteLine("3 pressed");
                        //print out fizzbuzz?
                        break;
                }

                // Wait for the user to respond before closing
                Console.Write("Press 'n' and Enter to close the app, or press Enter to continue: ");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }
                Console.WriteLine("\n");
            }
            return;
        }
    }
}
