﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter array size");
            //var size = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();
            int[] element = new int[50];
            /* Console.WriteLine("enter element in array");
             for (int j = 0; j < size; j++)
             {
                 element[j] = Convert.ToInt32(Console.ReadLine());
             }*/

            Console.WriteLine("\n enter your choice 1 for push \n 2 for pop \n 3 for display");
            var ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)

            {
                case 1:
                    Console.WriteLine("enter element to push");
                    int i = Convert.ToInt32(Console.ReadLine());
                    stack.Push(i);
                    stack.Display();
                    break;

                case 2:
                    stack.Pop();
                    stack.Display();
                    break;

                case 3:
                    stack.Display();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey(true);
        }
    }
}

    public class Stack
    {
        public int[] array = new int[10];
        int top = -1;
        public void Push(int i)
        {
            if (top == 9)
            {
                Console.WriteLine("aLREADY FULL");
            }
            else
            {
                top++;
                array[top] = i;
                Console.WriteLine("element inserted", array[top]);

            }

        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("already empty");
            }
            else
            {
                Console.WriteLine(array[top]);
                top--;
            }
        }
        public void Display()
        {
            for(int m=0;m<top;m++)
            {
                Console.WriteLine(array[m]);
            }
        }
 }


