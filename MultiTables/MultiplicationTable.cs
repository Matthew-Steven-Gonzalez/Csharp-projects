using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySolutions
{
    public class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for the multiplations of 2 - 10.");
            int userNum = int.Parse(Console.ReadLine());
            MultiTable(userNum);

        }

        static void MultiTable(int x)
        {
            int[] multi = {};

            for(int i = 2; i <= 10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}",x, i, (x*i));
            }
        }
    }
}