using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrateLoop
{
    class Program
    {
        public static void Main(string[] args)
        {

            double rate;

            do
            {
            Console.WriteLine("Please enter an hourly rate");
            rate = double.Parse(Console.ReadLine());
            }while(rate < 5.56 || rate > 49.99);

                Console.WriteLine("The rate of {0} is okay.", rate);
                        
        }
    }
}