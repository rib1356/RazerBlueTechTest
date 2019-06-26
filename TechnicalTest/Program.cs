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
            if(a1.Length != a2.Length) //If lengths arent the same return false as it cant be an anagram
            {
                return false;
            }

            char[] charArr1 = a1.ToLower().ToCharArray(); //Convert both strings to lowercase and put them into a character array
            char[] charArr2 = a2.ToLower().ToCharArray();

            Array.Sort(charArr1); //Sort the current arrays
            Array.Sort(charArr2);
    
            string newWord1 = new string(charArr1); //Turn the current char array into strings to be compared
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
            //Console.WriteLine("1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz\n16\n17\nFizz\n19\nBuzz\nFizz\n22\n23\nFizz\nBuzz\n26\nFizz\n28\n29\nFizzBuzz\n31\n32\nFizz\n34\nBuzz\nFizz\n37\n38\nFizz\nBuzz\n41\nFizz\n43\n44\nFizzBuzz\n46\n47\nFizz\n49\nBuzz\nFizz\n52\n53\nFizz\nBuzz\n56\nFizz\n58\n59\nFizzBuzz\n61\n62\nFizz\n64\nBuzz\nFizz\n67\n68\nFizz\nBuzz\n71\nFizz\n73\n74\nFizzBuzz\n76\n77\nFizz\n79\nBuzz\nFizz\n82\n83\nFizz\nBuzz\n86\nFizz\n88\n89\nFizzBuzz\n91\n92\nFizz\n94\nBuzz\nFizz\n97\n98\nFizz\nBuzz");
            var i = 1;
            var isTrue = true;
            char[] fizzBuzz = { 'F', 'i', 'z', 'z', 'B', 'u', 'z', 'z'  };
            while(isTrue)
            {
                if (ModFive(i) == 0 && ModThree(i) == 0)
                {
                    string toPrint = "";
                    foreach(char c in fizzBuzz)
                    {
                        toPrint += c;           
                    }
                    Console.WriteLine(toPrint);      
                }
                else if (ModThree(i) == 0)
                {
                    string toPrint = "";
                    for(var k = 0; k < 4; k++)
                    {
                        char c = fizzBuzz[k];
                        toPrint += c;           
                    }
                    Console.WriteLine(toPrint);  
                }
                else if (ModFive(i) == 0)
                {
                    string toPrint = "";
                    for(var k = 4; k < 8; k++)
                    {
                        char c = fizzBuzz[k];
                        toPrint += c;           
                    }
                    Console.WriteLine(toPrint);  
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
                if(i == 101)
                {
                    isTrue = false;
                }
            }

            int ModFive(int f)
            {

                return (f % 5);
            }

            int ModThree(int t)
            {
                return (t % 3);
            }


        }

        public static string IPv4(string IP)
        {
            string[] splitIPArr; 
            string[] singleIP = new string[2]; //Initialise the CIDR IP array
            if(IP.Contains("/")) //If true IP contains CIDR
            {
                singleIP = IP.Split('/'); //Split of the CIDR value to validate the IP address
                splitIPArr = singleIP[0].Split('.'); //Split the modified IP
            } else
            {
                splitIPArr = IP.Split('.'); //Split the original IP
            }

            if(splitIPArr.Length != 4) //If length of array is not 4 it cannot be a valid IP address
            {
                return "IP is not valid please try another";         
            }
            
            foreach (String single in splitIPArr) //Loop through each of the sections of the IP
            {
                if(!IsDigitsOnly(single)) //Checks if part of IP contains any letters
                {
                    return "IP doesnt contain all numbers";
                }
                if(single.Length > 3 || single.Length == 0){ //If blank value in IP eg 0.0..0/24 or 129.0004.0.1
                    return "IP is not valid please try another";
                }
                int temp = int.Parse(single); //Parse string to int to check the bounds of the IP address, range of 0-255
                if (temp > 255)
                {
                    return "IP is out of valid range please try another";
                }
             }
            return IP;

            bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app
            Console.WriteLine("RazorBlue Technical Test\r");
            Console.WriteLine("-------------------------\n");

            while(!endApp)
            {
                string anagram1 = "";
                string anagram2 = "";
                string IP = "";

                // Ask the user to choose an operator
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 - Anagram Comparison");
                Console.WriteLine("\t2 - IPv4");
                Console.WriteLine("\t3 - Worst Fizz Buzz implementation");
                Console.Write("Your option? ");

                switch(Console.ReadLine())
                {
                    case "1": //Anagram comparison
                      Console.Write("Type the first anagram and then press Enter: ");
                      anagram1 = Console.ReadLine();

                      Console.Write("Type the second anagram and then press Enter: ");
                      anagram2 = Console.ReadLine();

                      Console.WriteLine("------------------------\n"); //Make things more readable
                      Console.WriteLine(Options.AnagramComparison(anagram1, anagram2));
                      break;
                    case "2":
                        Console.Write("Enter an IPv4: ");
                        IP = Console.ReadLine();
                        Console.WriteLine("------------------------\n");
                        Console.WriteLine(Options.IPv4(IP));
                      break;
                    case "3":
                        Console.WriteLine("------------------------\n");
                        Options.WorstFizzBuzz();
                        break;
                }

                // Wait for the user to respond before closing
                Console.Write("Press 'n' and Enter to close the app, or press Enter to continue: ");
                if(Console.ReadLine() == "n")
                {
                    endApp = true;
                }
                Console.WriteLine("\n");
            }
            return;
        }
    }
}
