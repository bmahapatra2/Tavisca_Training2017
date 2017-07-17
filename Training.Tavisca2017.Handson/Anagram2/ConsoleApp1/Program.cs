using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Anagrams
    {
        static void Main(string[] args)
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
    public int anagram(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i].Equals(str[j]))
                    {
                        count = count++;
                        return count;
                    }

                    else
                    {
                        return str.Length;
                    }


                }

            }
        }
    }
}
