using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallsOfWestWood
{
    class Encounters
    {
        private static readonly Random rand = new Random();

        



        // Encounter Generic


        // Encounters
        public static void hallFight()
        {
        string titleCard1 = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
        string titleCard2 = "||                                                        ||";
        string titleCard3 = "||                    Halls Of WestWood                   ||";
        string titleCard4 = "||                    ~~~~~~~~~~~~~~~~~                   ||";
        string titleCard5 = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";


            Console.WriteLine(titleCard1);
            Console.WriteLine(titleCard2);
            Console.WriteLine("|| Before you stands a large beast. Covered head to foot  ||");
            Console.WriteLine("||       in fur with patches of blood in his coat.        ||");
            Console.WriteLine("||            You begin combat with it...                 ||");
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard1);
            Console.ReadKey();
            Combat(false, "werewolf", 2, 10);
        }

    
        // Encounter Tools 
        public static void Combat(bool random, string name, int power, int health)
        {

            string titleCard1 = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
            string titleCard2 = "||                                                        ||";
            string titleCard3 = "||                    Halls Of WestWood                   ||";
            string titleCard4 = "||                    ~~~~~~~~~~~~~~~~~                   ||";
            string titleCard5 = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
            
            string n = "";
            int p = 0;
            int h = 0;
    
            if(random)
            {

            }

            else
            {
                n = name;
                p = power;
                h = health;
            }
  
            while(h > 0 || Program.currentPlayer.health == 0 )
            {
                Console.Clear();
                Console.WriteLine(titleCard1);
                Console.WriteLine(titleCard2);
                Console.WriteLine(n);
                Console.WriteLine(h);
                Console.WriteLine(titleCard1);
                Console.WriteLine("|  (A)ttack   (D)efend |");
                Console.WriteLine("|   (R)un      (H)eal  |");
                Console.WriteLine(titleCard1);
                Console.WriteLine(" Potions:  "+ Program.currentPlayer.potions +"  Health:  " + Program.currentPlayer.health);
                Console.WriteLine(titleCard1);
                String? input = Console.ReadLine();
                if( input != null && input.ToLower() == "a" || input != null && input.ToLower() =="attack")
                {
                    // Attack
                    Console.WriteLine(titleCard1);
                    Console.WriteLine(titleCard2);
                    Console.WriteLine("You strike the "+ n + ", however they strike back");
                    int enemyDamage = p - Program.currentPlayer.armorValue;
                    if(enemyDamage < 0)
                    {
                        enemyDamage = 0;
                    
                    }
                    int playerDamage = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You deal " + Program.currentPlayer.damage + " Damage to the "+ n+" , but recieve "+ enemyDamage + " damage.");
                    Console.WriteLine(titleCard2);
                    Console.WriteLine(titleCard1);
                    Program.currentPlayer.health -= enemyDamage;
                    h -= playerDamage; 
                }
                else if(input != null && input.ToLower() == "d" || input != null && input.ToLower() =="defend")
                {
                    // defend
                    Console.WriteLine(titleCard1);
                    Console.WriteLine(titleCard2);
                    Console.WriteLine("You defend yourself from the "+ n + ", however they still strike you");
                    int enemyDamage = p/2 - Program.currentPlayer.armorValue;
                    if(enemyDamage < 0)
                    {
                        enemyDamage = 0;
                    
                    }
                    int playerDamage = rand.Next(0, Program.currentPlayer.weaponValue)/2;
                    Console.WriteLine("You deal " + Program.currentPlayer.damage / 4 + " Damage to the "+ n+" , but recieve "+ enemyDamage + " damage.");
                    Console.WriteLine(titleCard2);
                    Console.WriteLine(titleCard1);
                    Program.currentPlayer.health -= enemyDamage;
                    h -= playerDamage;
                }
                else if(input != null && input.ToLower() == "r" || input != null && input.ToLower() =="run")
                {
                    // Run
                    if(rand.Next(0,2) == 0)
                    {
                        Console.WriteLine(titleCard1);
                        Console.WriteLine(titleCard2);
                        Console.WriteLine("You run from the "+ n +" You slip exposing yourself to damage.");
                        int enemyDamage = p - Program.currentPlayer.armorValue;
                        Console.WriteLine("You lose "+ enemyDamage + "Health.");
                        Console.WriteLine(titleCard2);
                        Console.WriteLine(titleCard1);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine(titleCard1);
                        Console.WriteLine(titleCard2);
                        Console.WriteLine("Your quickfootedness pays off you get away from the " + n+ ".");
                        Console.WriteLine(titleCard2);
                        Console.WriteLine(titleCard1);
                        Console.ReadKey();
                        // Continue through castle
                    }
                }

                else if(input != null && input.ToLower() == "h" || input != null && input.ToLower() =="heal")
                {
                    // heal
                    if(Program.currentPlayer.potions == 0)
                    {
                        Console.WriteLine(titleCard1);
                        Console.WriteLine(titleCard2);
                        Console.WriteLine("You reach for a potion, but Oh NO you don't have any.");
                        int enemyDamage = p - Program.currentPlayer.armorValue;
                        if(enemyDamage < 0)
                        {
                            enemyDamage = 0;
                        
                        }
                        Console.WriteLine("The " + n + "strikes you for " + enemyDamage + ", Oh that hurt.");
                        Console.WriteLine(titleCard2);
                        Console.WriteLine(titleCard1);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You reach into the bag and pull out a poition.");
                        Console.WriteLine(titleCard2);
                        Console.WriteLine(titleCard1);
                        Console.ReadKey();
                        Program.currentPlayer.health += 5;
                    }
                }

                Console.ReadKey();
            }
            Console.WriteLine(titleCard1);
            Console.WriteLine(titleCard2);
            Console.WriteLine("You have Defeated a " + n);
            Console.WriteLine(titleCard2);
            Console.WriteLine(titleCard1);
            Console.ReadKey();
        }
        
    }
}