﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            for(int i=0;i<26;i++)
            { Console.WriteLine((int)a + i); }
            Console.ReadKey(true);
        }
    }
}
