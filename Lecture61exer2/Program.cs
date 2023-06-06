using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture61exer2

{
    class Program{
        static void Main(string[] args)
        {
            Taxpayer[] community = new Taxpayer[10];

            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("Please enter Social Security Number");
                string socialSecuityNum = Console.ReadLine();

                Console.WriteLine("Please Enter Yearly Income");
                double income = double.Parse(Console.ReadLine());

                community[i] = new Taxpayer(socialSecuityNum, income);

            }

            
        }
    } 
}