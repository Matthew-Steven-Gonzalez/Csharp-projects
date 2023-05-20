using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuess
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] words = new string[]{"Cheese", "Broccoli", "Diaper", "Orange", "Car", "Taco", "Game", "Zelda", "Unicorn"};

            Random r = new Random();
            Console.WriteLine(words.Length);

            string choosenWord = words[r.Next(0, words.Length)];
            Console.WriteLine(choosenWord);

            Console.WriteLine("We Have Choosen a Word.");

            bool correct = false;
            string

            do{
                for(int i = 0;i < choosenWord.Length;i++){
                    Console.Write("*");
                };
                Console.ReadKey();
                break;
            }while(correct == false);

        }
    }
}