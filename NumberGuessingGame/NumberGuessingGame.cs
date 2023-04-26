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

            Random r = new Random();

            int winNum = r.Next(0,100);

            bool win = false;

             Console.WriteLine("Guess a Number inbetween 0 and 100...");


            do
            {
                    string s = Console.ReadLine();

                    int i = int.Parse(s);

                    if(i > winNum)
                    {
                        Console.WriteLine("That number is too high...guess again.");
                        Console.ReadKey();
                    }
                    else if(i < winNum) 
                    {
                        Console.WriteLine("That number is too low...guess again...");
                         Console.ReadKey();

                    }
                    else if(i == winNum)
                    {
                        Console.WriteLine("Congratulations you have guessed the right number...");
                        win = true;
                    }
                } while (win == false);
            }
        }
    }
