using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;
using System.Text;

namespace CodeJam
{
    class LOTR
    {
        int GetMinimum(int[] replies)
        {
            int count = 0;
            int add = 0;
            int j = 0;
            Array.Sort(replies);
            for (j = 0; j < replies.Length; j++)
            {
                if (j != replies.Length - 1)
                {
                    if (replies[j] == replies[j + 1])
                    {
                        if (count != replies[j])
                        {

                            count++;
                        }
                        else
                        {
                            add += replies[j] + 1;
                            count =0;
                        }
                    }
                    else
                    {
                        add += replies[j] +1;
                        count = 0;
                    }
                }
                else
                {
                    add += replies[j];

                }
            }

            return add + 1;
        }

        #region Testing code Do not change
        public static void Main(String[] args)
        {

            LOTR lotr = new LOTR();
            String input = Console.ReadLine();
            do
            {
                int[] replies = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(lotr.GetMinimum(replies));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion

    }
}