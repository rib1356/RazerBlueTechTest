using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    class Options
    {
        public static Boolean AnagramComparison(string a1, string a2)
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

        public static void WorstFizzBuzz ()
        {
            var i = 0;
            var isTrue = true;
            //Console.WriteLine("1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz\nFizz\n22\n23\nFizz\nBuzz\n26\nFizz\n28\n29\nFizzBuzz\n31\n32\nFizz\n34\nBuzz\nFizz\n37\n38\nFizz\nBuzz\n41\nFizz\n43\n44\nFizzBuzz\n46\n47\nFizz\n49\nBuzz\nFizz\n52\n53\nFizz\nBuzz\n56\nFizz\n58\n59\nFizzBuzz\n61\n62\nFizz\n64\nBuzz\nFizz\n67\n68\nFizz\nBuzz\n71\nFizz\n73\n74\nFizzBuzz\n76\n77\nFizz\n79\nBuzz\nFizz\n82\n83\nFizz\nBuzz\n86\nFizz\n88\n89\nFizzBuzz\n91\n92\nFizz\n94\nBuzz\nFizz\n97\n98\nFizz\n");
            while(isTrue) //Would never use a while loop to run through a known set of values
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
                if(i == 101) //Needed to break out the loop
                {
                    isTrue = false;
                }
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
                      Console.Write("Type the first anagram and then press Enter: ");
                      anagram1 = Console.ReadLine();

                      Console.Write("Type the second anagram and then press Enter: ");
                      anagram2 = Console.ReadLine();

                      Console.WriteLine("------------------------\n");

                      Console.WriteLine(Options.AnagramComparison(anagram1, anagram2));
                      //Console.WriteLine(blah);
                      break;
                    case "2":
                        Console.WriteLine("2 pressed");
                      break;
                    case "3":
                        Options.WorstFizzBuzz();
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
