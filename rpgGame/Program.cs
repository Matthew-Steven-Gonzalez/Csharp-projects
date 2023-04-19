using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallsOfWestWood
{
    class Program
    {
        public static Player currentPlayer = new Player();

        static void Main(string[] args)
        {
            Start();
        }



        static void Start()
        {
            string lineBreak = "_________________________________________";
            Console.WriteLine("Welcome to the halls of WestWood?...");
            Console.WriteLine("What is your name hero?:  ");
            currentPlayer.name = Console.ReadLine();

            if(currentPlayer.name == "")
            {
                currentPlayer.name = " Wait...I don't remember...";
            }

            Console.Clear();
            Console.WriteLine("You awaken on the cold floor of a large banquet hall.\nYour head is clouded and your vison blurred\nThe only thing you know for sure is your name is " + currentPlayer.name);
            Console.WriteLine(lineBreak);
            Console.WriteLine("A choice is to be made...  ");
            Console.WriteLine(lineBreak);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(lineBreak);
            Console.WriteLine("Ahead of you is 2 halls.");
            Console.WriteLine("On the left is a dark hall with candles barely illuminating a neverending hall.");

            



        }
    }
} 