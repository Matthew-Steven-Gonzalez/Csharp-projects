using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string topFill =    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";

            string bottomFill = "_______________________________________________";

            Random r = new Random();

            int winNum = r.Next(0,10);

            bool win = false;



            do
            {
                    Console.WriteLine("Guess a Number inbetween 0 and 10...");

                    string? s = Console.ReadLine();

                    int i = int.Parse(s);

                    if(i > winNum)
                    {
                        Console.WriteLine("That number is too high...guess again.");
                        Console.WriteLine(topFill);
                        Console.WriteLine("Guess Again...");
                        Console.WriteLine(bottomFill);


                    }
                    else if(i < winNum) 
                    {
                        Console.WriteLine("That number is too low...guess again...");
                        Console.WriteLine(topFill);
                        Console.WriteLine("Guess Again...");
                        Console.WriteLine(bottomFill);
                    }
                    else if(i == winNum)
                    {
                        Console.WriteLine(topFill);
                        Console.WriteLine("Congratulations you have guessed the right number...");
                        win = true;
                    }
                    Console.WriteLine();
                } while (win == false);
            }
        }
    }
