using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //5! MEAN 5X4X3X2X1
            Console.WriteLine("Factoral machine");
            Console.Write ("please enternum");
            int n = 0;
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("please enternum");
            }


            /*
            int factorial = 1;

            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{n} factoral is {factorial}");
            */

            int factorial = calcfact(n);
            Console.WriteLine($"{n} factoral is {factorial}");




        }
        static int calcfact(int n)
        {
            if (n == 1)
            {
                return 1;

            }

            return n * calcfact(n - 1);
        }

    }


}
