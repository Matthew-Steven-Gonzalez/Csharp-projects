using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(String[] args)
        {

            //String exercise
            string myString;

            Console.WriteLine("Please Enter your name and press enter");

            myString = Console.ReadLine();

            Console.WriteLine("Your name uppercased: {0} ",myString.ToUpper());

            Console.WriteLine("Your name lowercased: {0}",myString.ToLower());

            Console.WriteLine("This method removes extraspace: {0} ",myString.Trim());

            Console.WriteLine("This method removes the first 3 letters of your name: {0}", myString.Substring(2));

            //String and its methods 2

            Console.WriteLine("Enter a string here: ");
            //user input string
            string userString = Console.ReadLine();

            Console.WriteLine("Enter Character To search: ");
            //user searched letter char
            char searchedLetter = Console.ReadLine();

            //if else statment for if character is present.
            if(userString.Contains(searchedLetter))
            {
                Console.WriteLine("Your letter is there its occurs first at {0}." , userString.IndexOf(searchedLetter));
            }
            else
            {
                Console.WriteLine("Your letter is not in the word. Thank you.");
            }

            //First and last name concatenation
            Console.WriteLine("Enter your first name: ");
            string userFN = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string userLN = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}. How are you?",userFN, userLN);
            string userMood = Console.ReadLine();

            if(userMood.ToLower() == "good" || userMood.ToLower() == "great" || userMood.ToLower() == "happy")
            {
                Console.WriteLine("Good for you. I'm happy for you.");
            }
            else
            {
                Console.WriteLine("Cheer up I hope you feel better.");
            }



            //datatype challenge
            byte value1 = 1;
            sbyte value2 = 1;
            int value3 = 1;
            uint value4 = 1;
            short value5 = 1;
            ushort value6 = 1;
            long value7 = 1;
            ulong value8 = 1;
            float value9 = 1.0f;
            double value10 = 1.2;
            char value11 = "a";
            bool value12 = true;
            object value13;
            string value14 = "I control Text";
            decimal value15 = 2.4m;


        }
        
    }
}