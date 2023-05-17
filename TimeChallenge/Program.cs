using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChallenge
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time, hours, minuets;

            Console.WriteLine("Please Enter total minutes and TIMe will update to hours and minuets.");

            time = Int32.Parse(Console.ReadLine());

            hours = time / 60;

            minuets = time % 60;

            Console.WriteLine(String.Format("TIMe: time converted Hours: {0} and Minutes:{1}. ",hours, minuets));
        }
    }
}