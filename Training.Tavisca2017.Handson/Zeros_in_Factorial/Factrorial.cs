using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeros_in_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number :");
            int n = int.Parse(Console.ReadLine());
            long factorial = 1; int timesZero = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }


            Console.WriteLine(factorial);

            while (factorial % 10 == 0)
            {
                timesZero++;
                factorial /= 10;
            }
            Console.WriteLine(timesZero);
            Console.ReadLine();





        }

    }
    }

