using System;
using System.Linq;


namespace Calculator
{
    class Program
    {
        public static void Main(string[] arg)
        {


            string operation, confirmation = "yes";

            int value1, value2, total;

            Console.WriteLine("Hello and welcome to calculator. Here we can do basic addtion, subtraction, multiplication, and diviison with whole numbers.");

            while(confirmation == "yes" || confirmation == "y" || confirmation == "sure")
            {
                Console.WriteLine("Please enter your first number:");
                value1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your second number:");
                value2 = int.Parse(Console.ReadLine());
                Console.WriteLine("What kind of math do you want to do?(add , sub, multi, div)");
                operation = Console.ReadLine().ToLower();


                switch(operation)
                {
                    case "add":
                        total = value1 + value2;
                        Console.WriteLine("{0} + {1} = {2}", value1, value2, total);
                        Console.WriteLine("Do you want to math again?");
                        confirmation = Console.ReadLine().ToLower();
                        break;
                    
                    case "sub":
                        total = value1 - value2;
                        Console.WriteLine("{0} - {1} = {2}", value1, value2, total);
                        Console.WriteLine("Do you want to math again?");
                        confirmation = Console.ReadLine().ToLower();
                        break;

                    case "multi":
                        total = value1 * value2;
                        Console.WriteLine("{0} x {1} = {2}", value1, value2, total);
                        Console.WriteLine("Do you want to math again?");
                        confirmation = Console.ReadLine().ToLower();
                        break;

                    case "div":
                        total = value1 / value2;
                        Console.WriteLine("{0} / {1} = {2}", value1, value2, total);
                        Console.WriteLine("Do you want to math again?");
                        confirmation = Console.ReadLine().ToLower();
                        break;

                    default:
                        Console.WriteLine("Your input doesn't match our math functions. Sorry.");
                        confirmation = "yes";
                        break;

                }
            }
            Console.WriteLine("Thank you for using calculator.");

        }

    }
}