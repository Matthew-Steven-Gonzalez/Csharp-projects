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
            Console.WriteLine("Please enter an hourly rate");

            double rate = double.Parse(Console.ReadLine());

            if (rate > 7.50 && rate < 49.00)
            {
                Console.WriteLine("That rate is okay.");
            }
            else
            {
                Console.WriteLine("Error with that pay rate.");
            }
        }
    }
}