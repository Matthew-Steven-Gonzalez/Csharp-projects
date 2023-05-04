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

        Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
        Console.WriteLine("||    Hello, Welcome to choice...    ||");
        Console.WriteLine("|| How many items/choices are there? ||");
        Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
        


        string? UI = Console.ReadLine();

        int choice = Convert.ToInt32(UI);

        int num = r.Next(1, choice);

        switch(num)
        {
            case 1:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... A/1      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
            break;
            case 2:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... B/2      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();

            break;
            case 3:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... C/3      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();

            break;
            case 4:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... D/4      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
            break;
            case 5:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... E/5      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();

            break;
            case 6:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... F/6      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
            break;
            case 7:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... G/7       ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
            break;
            case 8:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... H/8      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
            break;
            case 9:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... I/9      ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
            break;
            case 10:
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("||      The Universe Has Spoken:     ||");
                Console.WriteLine("||       Your Choice is ... J/10     ||");
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||");
                Console.ReadKey();
            break;

        }
        }
    }
