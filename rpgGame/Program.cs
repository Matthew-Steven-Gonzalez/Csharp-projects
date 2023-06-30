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
            string titleCard1 = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
            string titleCard2 = "||                                                        ||";
            string titleCard3 = "||                    Halls Of WestWood                   ||";
            string titleCard4 = "||                    ~~~~~~~~~~~~~~~~~                   ||";
            string titleCard5 = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine(titleCard2);
            Console.WriteLine("||            Welcome to the halls of WestWood?...        ||");
            Console.WriteLine("||                 What is your name hero?:               ||");
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard5);
            currentPlayer.name = Console.ReadLine();

            if(currentPlayer.name == "" )
            {
                currentPlayer.name = " Wait,I don't remember.";
            }

            Console.Clear();
            Console.WriteLine(titleCard1);
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard3);
            Console.WriteLine(titleCard4);
            Console.WriteLine(titleCard5);
            Console.WriteLine(titleCard2);
            Console.WriteLine("||  You awaken on the cold floor of a large banquet hall. ||");
            Console.WriteLine("||       Your head is clouded and your vison blurred.     ||");
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(titleCard1);
            Console.WriteLine(titleCard2);
            Console.WriteLine("||     A choice is to be made. Ahead of you is 2 halls.   ||");
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard5);
            Console.WriteLine(titleCard1);
            Console.WriteLine(titleCard2);
            Console.WriteLine("||      On the left is a dark hall with candles barely    ||");
            Console.WriteLine("||            illuminating a never-ending hall.           ||");
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard5);
            Console.WriteLine(titleCard1);
            Console.WriteLine(titleCard2);
            Console.WriteLine("||   On the right is a door with swords crossed overhead  ||");
            Console.WriteLine("||    what appears to be blood splater across the door.   ||");
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard5);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(titleCard1);
            Console.WriteLine(titleCard2);
            Console.WriteLine("||                 Which route do you take...             ||");
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard5);
            String? choice1 = Console.ReadLine();
            Console.Clear();

            if(choice1 != null && choice1 == "right")
            {    
                Console.WriteLine(titleCard1);
                Console.WriteLine(titleCard5);
                Console.WriteLine(titleCard2);
                Console.WriteLine("||        You reach out for the cold steel of the         ||");
                Console.WriteLine("||                 handle on the door.                    ||");
                Console.WriteLine(titleCard2);
                Console.WriteLine(titleCard5);
                if (currentPlayer.keys >= 1)
                {
                    Console.WriteLine(titleCard1);
                    Console.WriteLine(titleCard5);
                    Console.WriteLine(titleCard2);
                    Console.WriteLine("||  You insert the key you found into the door and turn...||");
                    Console.WriteLine("||         You hear a click... You are free from ...      ||");
                    Console.WriteLine(titleCard3);
                    Console.WriteLine(titleCard2);
                    Console.WriteLine(titleCard5);

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(titleCard1);
                    Console.WriteLine(titleCard3);
                    Console.WriteLine(titleCard5);
                    Console.WriteLine(titleCard2);
                    Console.WriteLine("You see a keyhole , but currently have no keys...");
                    Console.WriteLine(titleCard2);
                    Console.WriteLine(titleCard5);

                    Console.ReadKey();
                    Console.Clear();

                }
            }
            else if(choice1 != null && choice1.ToLower() == "left")
            {
                Console.Clear();

                Console.WriteLine(titleCard1);
                Console.WriteLine(titleCard3);
                Console.WriteLine(titleCard5);
                Console.WriteLine("||         You slowly begin walking down the hall.        ||");
                Console.WriteLine("||    a creaking noise ahead causes the hair to raise on  ||");
                Console.WriteLine("||         your neck... It's about to get hairy...        ||");
                Console.WriteLine(titleCard2);
                Console.WriteLine(titleCard5);

                Console.ReadKey();
                Console.Clear();
                Encounters.hallFight();

            }
            



        }
    }
} 