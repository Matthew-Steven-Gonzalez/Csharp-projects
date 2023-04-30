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
            string titleCard = "________________Halls_Of_WestWood__________________";
            string lineBreak = "___________________________________________________";
            string emptyBreak= "                                                   ";
            Console.WriteLine("Welcome to the halls of WestWood?...");
            Console.WriteLine("What is your name hero?:  ");
            currentPlayer.name = Console.ReadLine();

            if(currentPlayer.name == "" )
            {
                currentPlayer.name = " Wait...I don't remember...";
            }

            Console.Clear();
            Console.WriteLine(titleCard);
            Console.WriteLine(lineBreak);
            Console.WriteLine("You awaken on the cold floor of a large banquet hall.\nYour head is clouded and your vison blurred\nThe only thing you know for sure is your name is " + currentPlayer.name);
            Console.WriteLine(emptyBreak);
            Console.WriteLine(lineBreak);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(titleCard);
            Console.WriteLine(lineBreak);
            Console.WriteLine("A choice is to be made...  ");
            Console.WriteLine("Ahead of you is 2 halls.");
            Console.WriteLine("On the left is a dark hall with candles barely illuminating a never-ending hall.");
            Console.WriteLine("On the right is a door with swords crossed overhead and what appears to be blood splater across the door.");
            Console.WriteLine("Which route do you take...");
            Console.WriteLine(emptyBreak);
            Console.WriteLine(lineBreak);
            String? choice1 = Console.ReadLine();
            Console.Clear();

            if(choice1 != null && choice1 == "right")
            {    
                Console.WriteLine("You reach out for the cold steel of the handle on the door and tug.");
                if(currentPlayer.keys >= 1)
                {
                    Console.WriteLine(titleCard);
                    Console.WriteLine(lineBreak);
                    Console.WriteLine("You insert the key you found into the door and turn...You hear a click...");
                    Console.WriteLine(emptyBreak);
                    Console.WriteLine(lineBreak);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(titleCard);
                    Console.WriteLine(lineBreak);
                    Console.WriteLine("You see a keyhole , but currently have no keys...");
                    Console.WriteLine(emptyBreak);
                    Console.WriteLine(lineBreak);
                    Console.ReadKey();
                    Console.Clear();

                }
            }
            else if(choice1 != null && choice1.ToLower() == "left")
            {
                Console.Clear();
                Console.WriteLine(titleCard);
                Console.WriteLine(lineBreak);
                Console.WriteLine("You slowly begin walking down the hall.");
                Console.WriteLine("a creaking noise ahead causes the hair to raise on your neck... It's about to get hairy...");
                Console.WriteLine(emptyBreak);
                Console.WriteLine(lineBreak);
                Console.ReadKey();
                Console.Clear();
                Encounters.hallFight();

            }
            



        }
    }
} 