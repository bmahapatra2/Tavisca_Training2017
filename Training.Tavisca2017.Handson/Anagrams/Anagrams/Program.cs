using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Diagnostics;
using System.IO;
using 

namespace Codejam
{
    class Anagrams
    {
        int[] array = new int[50];
        String[] sorted_word = new String[50];

        String[] ch1 = new String[50];
        String[] ch2 = new String[50];

        int GetMaximumSubset(string[] words)
        {
            int count = 0;
            int ana = 0;

            for (int i = 0; i < words.Length; i++)
            {
                array[i] = words[i].Length;
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Char[] chararray1 = words[i].ToCharArray();
                        Array.Sort(chararray1);

                        sorted_word[i] = Convert.ToString( chararray1[i]);
                        string.Concat(sorted_word);
                        // chararray1.Concat(ToString);
                    }

               }
                    
            }              
                int uniqueItems =Convert.ToInt32 (sorted_word.Distinct());
                return uniqueItems;
            //int sum = words.Length - ana;
            //return sum;
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
