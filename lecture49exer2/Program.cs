using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer for it to be cubed and sqaured.");
            int userNum = int.Parse(Console.ReadLine());
            int userNumSquared = squared(userNum);
            Console.WriteLine(userNumSquared);
            int userNumCubed = cubed(userNum);
            Console.WriteLine(userNumCubed);

        }

        public static int squared(int x)
        {
            return x * x;
        }

        public static int cubed(int x)
        {
            return squared(x) * x;
        }
    }
}
