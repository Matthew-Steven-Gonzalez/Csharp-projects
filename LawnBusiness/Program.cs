using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyRate
{
    class Program
    {
        public static void Main(string[] args)
        {
            // gets the L
            Console.WriteLine("Please enter length of yard: ");
            int length = int.Parse(Console.ReadLine());

            // gets the W
            Console.WriteLine("Please enter width of yard: ");
            int width = int.Parse(Console.ReadLine());

            // get the area of yards (L X W)
            int area = length * width;

            // logic test to find size for cost multuplied by 20 week season.

            int cost = 0;

            if(area < 400)
            {
                cost = 25 * 20;
            }
            else if(area >= 400 && area < 600)
            {
                cost = 35 * 20;
            }
            else
            {
                cost = 50 *20;
            }

            // informing user of costs.

            Console.WriteLine("The total for your service is ${0}.00, based on the size of your yard {1}.", cost, area);
        }
    }
}