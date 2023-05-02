using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MakeAChoice
{
    static void Main(string[] args)
        {
            app();
        }


    static void app()
    {
        Random r = new Random();

        Console.WriteLine("Hello, Welcome to choice...");
        Console.WriteLine("How many items/choices are there?");

        string UI = Console.ReadLine();

        int choice = Convert.ToInt32(UI);

        int num = r.Next(1, choice);

        switch(num)
        {
            case 1:
                Console.WriteLine("A");
            break;
            case 2:
                Console.WriteLine("B");
            break;
            case 3:
                Console.WriteLine("C");
            break;
            case 4:
                Console.WriteLine("D");
            break;
            case 5:
                Console.WriteLine("E");
            break;
            case 6:
                Console.WriteLine("F");
            break;
            case 7:
                Console.WriteLine("G");
            break;
            case 8:
                Console.WriteLine("H");
            break;
            case 9:
                Console.WriteLine("I");
            break;
        }
        }
    }
