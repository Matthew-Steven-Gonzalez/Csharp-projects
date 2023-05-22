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
            Random r = new Random();

            string[] words = new string[]{"Cheese", "Broccoli", "Diaper", "Orange", "Car", "Taco", "Game", "Zelda", "Unicorn"};

            string choosenWord = words[r.Next(0, words.Length)];

            bool correct = false;

            string correctGuess = "";

            string playerGuess = "";

            string guessedWord = new string('_', chosenWord.Length);

            Console.WriteLine("We Have Choosen a Word.");

            do{        
                Console.WriteLine("|| Please guess a letter ||");
                playerGuess = Console.ReadKey();

                if(guessedWord.Contains(playerGuess))
                {
                    
                }
                

            }while(correct == false);

        }
    }
}