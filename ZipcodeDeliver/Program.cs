﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipcodeDeliver
{
    class Program
    {
        public static void Main(string[] args)
        {

            // int[] zipWeDo = new int[]{23451,77654,93847,16253,16253,74635,84756,83627,91029,00202};

            // Console.WriteLine("Please enter a zipCode :");
            // int customZip = int.Parse(Console.ReadLine());

            
            //     if(zipWeDo.Contains(customZip))
            //     {
            //         Console.WriteLine("We do Deliver there.");
            //     }
            //     else
            //     {
            //         Console.WriteLine("We do NOT Deliver there.");
            //     }
            //     Console.WriteLine("Thank you...");


                // Course Solution: 

            string[] zipWeDo = new string[]{"23451","77654","93847","16253","16253","74635","84756","83627","91029","00202"};


            Console.WriteLine("Please enter a zipCode :");
            string code = Console.ReadLine();
            bool found = false;

            for(int i = 0; i <zipWeDo.Length;i++)
            {
                if(zipWeDo[i] == code)
                {
                    found = true;
                    break;
                }
            }

            if(found)
            {
                Console.WriteLine("We do deliver there.");
            }
            else
            {
                Console.WriteLine("We do NOT deliver there");
            }

        }
    }
}