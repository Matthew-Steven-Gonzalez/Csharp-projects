using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum51
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum51 = 0;

            for(int i = 1; i <= 50;i++)
            {
                sum51 += i;
                Console.WriteLine("This is loop #{0} and the sum is {1}", i, sum51);
            }

            Console.WriteLine("For am I still waiting for that 1 {0}", sum51);
        }
    }
}