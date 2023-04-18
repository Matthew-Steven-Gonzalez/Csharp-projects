using System;

public class followAlong
{
    public static void Main()
    {
        System.Console.WriteLine("Hello, World!");

        //Data Types
        // int myInt = 1;  int
        // float myFloat = 1f;  float
        // bool myBoolean = true; booleans
        // string myName = "John"; Strings
        // char myChar = 'a'; Characters
        // double myDouble = 1.75;  Doubles

        // Enums are integers that should be used when an integer is used to specify an option from a fixed amount of options.

        // public enum CarType
        // {
        //     Toyota = 1,
        //     Honda = 2,
        //     Ford = 3,
        // }
        //     }

        //    Define three variables:

        // A string named productName equal to TV.
        // An integer named productYear equal to 2012.
        // A float named productPrice equal to 279.99f.

        string productName = "TV";
        int productYear = 2012;
        float productPrice = 279.99f;

        // Convert myDBL to int and print it.

        double myDBL = Convert.ToInt32(99.0);


    // Construct a list of the first 5 prime numbers (2, 3, 5, 7, 11) called primeNumbers.

        List<int> primeNumbers = new List<int>();
            
        primeNumbers.Add(2);
        primeNumbers.Add(3);
        primeNumbers.Add(5);
        primeNumbers.Add(7);
        primeNumbers.Add(11);

    // Dictionaries are special lists, whereas every value in the list has a key which is also a variable. A good example for a dictionary is a phone book. 

    // Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.

    // Here is the inventory specification:

    // 3 of type apple
    // 5 of type orange
    // 2 of type banana 

        Dictionary<string, long> inventory = new Dictionary<string, long>();
            
        inventory.Add("apple", 3);
        inventory.Add("orange", 5);
        inventory.Add("banana", 2);
        

    //Use string formatting to format the variables firstName, lastName and age to form the following sentence into the string sentence:

    // John Doe is 27 years old.

        string firstName = "John";
        string lastName = "Doe";
        int age = 27;

        // TODO: change this
        string sentence = String.Format("{0} {1} is {2} years old." ,firstName, lastName, age);

        Console.WriteLine(sentence);
    }
}
