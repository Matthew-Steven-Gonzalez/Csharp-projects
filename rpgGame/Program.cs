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
            Console.WriteLine("The large wooden doors swing open to an empty banquet hall.");
            Console.WriteLine("Wall are adorned with old paintings cracking from aging. Candles hung on the wall tease the dark maze like halls ahead. A choice is to be made... ")
            Console.WriteLine(lineBreak);


        }
    }
} 