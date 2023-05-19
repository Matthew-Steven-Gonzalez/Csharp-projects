using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersFinal
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many Students are in you class?");

            int numOfStudents = int.Parse(Console.ReadLine());

            string[,] array = new string[numOfStudents, 2];

            for(int i = 0; i < numOfStudents ;i++)
            {
                Console.WriteLine("What is student #{0} name?",(i+1));
                array[i,0] = Console.ReadLine();
                Console.WriteLine("What is student #{0} final Grade?",(i+1));
                array[i,1] = Console.ReadLine();
            }

            int highest = 0;

            string highestStudent = "";

            int average = 0;

            for(int i = 0;i < numOfStudents;i++)
            {
                if(int.Parse(array[i,1]) > highest)
                {
                    highest = int.Parse(array[i,1]);
                    highestStudent = array[i,0];
                }
                average += int.Parse(array[i,1]);
            }


            Console.WriteLine("The average of the class is {0}", (average / numOfStudents));

            Console.WriteLine("The highest grade in the class is a {0} and it belongs to {1}.",highest, highestStudent);

        }
    }
}