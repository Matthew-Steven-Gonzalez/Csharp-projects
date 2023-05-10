using System;
using System.Linq;


namespace Calculator
{
    class Program
    {
        public static void Main(string[] arg)
        {

            bool confirmation = false;

            string operation;

            int value1, value2, total;


            while(confirmation = false)
            {
            Console.WriteLine("Hello and welcome to calculator. Here we can do basic addtion, subtraction, multiplication, and diviison with whole numbers.");
            Console.WriteLine("Please enter your first number:");
            value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number:");
            value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What kind of math do you want to do?(add , sub, multi, div)");
            operation = Console.ReadLine().ToLower();

            // while(operation != "add" || operation != "sub" || operation != "multi" || operation != "div")
            // {
            //     Console.WriteLine("Please select proper answer. (add, sub, multi, div)");
            //     operation = Console.ReadLine().ToLower();

            // }

            switch(operation)
            {
                case "add":
                    total = value1 + value2;
                    Console.WriteLine("{0} + {1} = {2}", value1, value2, total);
                    Console.WriteLine("Do you want to math again?");
                    confirmation = Convert.ToBoolean(Console.ReadLine());
                    break;
                
                case "sub":
                    total = value1 - value2;
                    Console.WriteLine("{0} - {1} = {2}", value1, value2, total);
                    Console.WriteLine("Do you want to math again?");
                    confirmation = Convert.ToBoolean(Console.ReadLine());
                    break;

                case "multi":
                    total = value1 * value2;
                    Console.WriteLine("{0} x {1} = {2}", value1, value2, total);
                    Console.WriteLine("Do you want to math again?");
                    confirmation = Convert.ToBoolean(Console.ReadLine());
                    break;

                case "div":
                    total = value1 / value2;
                    Console.WriteLine("{0} / {1} = {2}", value1, value2, total);
                    Console.WriteLine("Do you want to math again?");
                    confirmation = Convert.ToBoolean(Console.ReadLine());
                    break;
            }
        }
        }

    }
}