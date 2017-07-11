using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class substring
    {
        static void Main(string[] args)
        {
           
                substring s = new substring();
                s.push();




            }
            void push()
            {

                int top = -1;
                Console.WriteLine("enter the string:");
                String s = Console.ReadLine();
                var character = s.ToCharArray();
                Console.WriteLine("Original string: {0}", s);
                Console.WriteLine("Character array:");
                for (int i = 0; i < character.Length; i++)
                {
                    Console.WriteLine("{0} {1}", i, character[i]);



                }

                Console.WriteLine("enter the string to compare:");
                String s1 = Console.ReadLine();
                var character1 = s1.ToCharArray();
                Console.WriteLine("String to compare: {0}", s1);
                Console.WriteLine(":");
                for (int j = 0; j < character1.Length; j++)
                    Console.WriteLine("{0} {1}", j, character1[j]);

                if (s.Contains(s1))
                {
                    Console.WriteLine("s is substring of s1");
                }
                else
                {
                    Console.WriteLine("s is not the substring");
                }

                Console.ReadLine();

            }

        }
    }

