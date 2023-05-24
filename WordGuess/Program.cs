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

            // Random Word selection
            Random r = new Random();

            string[] words = new string[]{"cheese", "broccoli", "diaper", "orange", "car", "taco", "game", "zelda", "unicorn"}; 

            string choosenWord = words[r.Next(0, words.Length)];

            string hiddenWord = new string('*', choosenWord.Length);

            Console.WriteLine("We Have Choosen a Word.");

            Console.WriteLine(hiddenWord);

            // Guess 

            while(hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word : {0}", hiddenWord);
                Console.WriteLine("Guess a letter >>");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false; 
                for (int i = 0;i < choosenWord.Length;i++)
                {
                    if( choosenWord[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i,1);
                        hiddenWord = hiddenWord.Insert(i,letter.ToString());
                        containsLetter = true;
                    }
                }
                if(containsLetter)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes! {0} is in the word!",letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("no! {0} is not in the word.",letter);

                }
                Console.ResetColor();
            }

        }
    }
}
