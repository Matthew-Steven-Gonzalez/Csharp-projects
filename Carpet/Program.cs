using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpet
{
    class Program
    {
        public static void Main(string[] args)
        {
            int length;
            int width;
            const float price = 4.56f;
            
            Console.WriteLine("Please enter the length of the room:");
            length = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please enter the width of the room:");
            width = int.Parse(Console.ReadLine());
            Console.Clear();
            

            int roomArea = width * length;

            float total =  price * (float) roomArea;

            Console.WriteLine(String.Format("Your total ammount to carpet your room is: ${0:0.##}", total));

        }
    }
}
