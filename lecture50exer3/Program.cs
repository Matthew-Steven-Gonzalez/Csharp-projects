using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(2,3,4,5);
            Sum(3, 4);

        }

        public static void Sum(params int[] nums)
        {
            int sum = 0;

            for(int i = 0;i < nums.Length;i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);
        }
    }
}