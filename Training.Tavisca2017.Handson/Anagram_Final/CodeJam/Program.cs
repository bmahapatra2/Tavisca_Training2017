using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Diagnostics;
using System.IO;
namespace Codejam
{
    class Anagrams
    {
        int[] array = new int[50];
         

        int GetMaximumSubset(string[] words)
        {
            int count = 0;
            
            for (int i = 0; i < words.Length; i++)
            {
                array[i] = words[i].Length;
            }
            
            for (int i = 0; i < words.Length; i++)
            {
                //for (int j = 0; j < array.Length; j++)
                //{
                    //if (array[i] == array[j])
                    //{
                        Char[] chararray1 = words[i].ToCharArray();
                        Array.Sort(chararray1);

                        //sorted_word[i] = Convert.ToString(chararray1[i]);
                        words[i] = string.Concat(chararray1);
                        // chararray1.Concat(ToString);
                    //}
                //}
            }
            var result = words.Distinct().Count();
            int m = Convert.ToInt32(result);
            return m;
        }





        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            Anagrams anagramSolver = new Anagrams();
            do
            {
                string[] words = input.Split(',');
                Console.WriteLine(anagramSolver.GetMaximumSubset(words));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}

