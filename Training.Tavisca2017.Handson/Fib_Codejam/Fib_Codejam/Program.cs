using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class TriFibonacci
    {
        public int Complete(int[] test)
        {


            for (int i = 3; i < test.Length;)
            {
                if (test[i] != -1)
                {
                    i++;
                }
                else
                {
                    test[i] = test[i - 1] + test[i - 2] + test[i - 3];
                    return test[i];
                }
            }
            for (int i = 3; i < test.Length; i++)
            {
                if (test[i] != test[i - 1] + test[i - 2] + test[i - 3])
                {
                    //if (test[i] == -1)

                    //[i] = test[i - 1] + test[i - 2] + test[i - 3];
                    return -1;

                }
                else
                {
                    return (test[i]);
                }
            }

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] <= 0 || test[i] != test[i - 1] + test[i - 2] + test[i - 3])
                {
                    return (-1);
                }

            }

            for (int i = test.Length; i > 2; i--)
            {
                if (test[i - 3] != test[i] - test[i - 1] - test[i - 2])
                {
                    return test[test.Length - 3];
                }
            }
            return -1;
        }

    }



   
    
        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            TriFibonacci triFibonacci = new TriFibonacci();
            do
            {
                string[] values = input.Split(',');
                int[] numbers = Array.ConvertAll<string, int>(values, delegate (string s) { return Int32.Parse(s); });
                int result = triFibonacci.Complete(numbers);
                Console.WriteLine(result);
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    
}





































