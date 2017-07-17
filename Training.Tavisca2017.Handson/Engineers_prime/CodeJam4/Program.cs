using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    public class EngineersPrimes
    {
        int[] arr = new int[50];

        long SmallestNonPrime(int n)
        { 

            int flag = 0,k=0;
            for (int i = 2; i <= n; i++)
            {

                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {

                        arr[k] = i;
                        k++;
                    }


                    if (flag == 0)
                    {
                        for (int m = 0; m < arr.Length; m++)
                        {
                            Console.WriteLine(arr[m]);
                        }

                    }

                }
            }
            return Int64.MinValue;
        }
            #region Testing code Do not change
            public static void Main(String[] args)
            {
                EngineersPrimes engineersPrimes = new EngineersPrimes();
                String input = Console.ReadLine();
                do
                {
                    Console.WriteLine(engineersPrimes.SmallestNonPrime(Int32.Parse(input)));
                    input = Console.ReadLine();
                } while (input != "-1");
            }
            #endregion
        
    }
}