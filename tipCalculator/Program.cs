using System;
using System.Linq;

namespace tipCalculator
{
    class tipCalculator
    {
        static void Main(string[] args)
        {

            bool confirmation = false;
            float tip = 0;


            // Get the bill amount:
            Console.WriteLine("Enter the total Bill: ");
            float bill = float.Parse(Console.ReadLine());
            Console.Clear();

            while(confirmation == false)
            {
                // Get the tip % amount:
                Console.WriteLine("What percentage would you like to tip?");
                float tipPercent = float.Parse(Console.ReadLine());

                // Calculate tip amount:
                tip = tipPercent/100 * bill;
                Console.WriteLine(String.Format("Your Tip is : ${0:0.##}",tip));
                Console.WriteLine("Is that okay? (yes/no)");
                String userInput = Console.ReadLine().ToLower();
                if( userInput == "yes" || userInput == "y")
                {
                    confirmation = true;
                }
                else{
                    confirmation = false;
                }
                Console.Clear();
            }
            
            // Calculate total:
            float total = bill + tip;
            Console.WriteLine(String.Format("Your total ammount with tip is: ${0:0.##}", total));
        }
    }
}