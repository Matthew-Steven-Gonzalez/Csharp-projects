using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandDDice
{
    class Program
    {
        public static void Main(string[] args)
        {
            string confirmation = "yes";

            while(confirmation == "yes" || confirmation == "y"|| confirmation == "true")
            {
                Console.Clear();
                Console.WriteLine("How many sides does your dice have?");
                int sides = int.Parse(Console.ReadLine());
                int theRoll = keepRolling(sides);
                Console.WriteLine("Your roll is : {0}",theRoll);

                Console.WriteLine("Keep Rolling?");
                confirmation = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you and Happy Critical.");

        }

        public static int keepRolling(int numOfSides)
        {
            Random rn = new Random();

            int roll = rn.Next(1,numOfSides);
                
            return roll;
            
        }
    }
}