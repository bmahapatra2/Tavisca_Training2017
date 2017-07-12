using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queue_Using_2stacks
{
    class Program
    {
        Stack1 insi = new Stack1();
        Stack1 outsi = new Stack1();
        
      public  static void Main(string []args)
        {
            Program p = new Program();
            p.Equeue();
            p.dqueue();
            Console.ReadKey(true);
        }

                public void Equeue()
            {
                Console.WriteLine("enter the values");
                int input = Convert.ToInt32(Console.ReadLine());
                insi.Push(input);
            }
                public void dqueue()
            {
                if(outsi.top < 0)
                {
                while (insi.top>=0)
                {
                    outsi.Push(insi.Pop());
                }
                }Console.ReadKey(true);
            }
        
    }

    public class Stack1
    {
        public int[] array = new int[10];
        public int top = -1;
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

        public int Pop()
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
            return 0;
        }
        public void Display()
        {
            for (int m = 0; m < top; m++)
            {
                Console.WriteLine(array[m]);
            }Console.ReadKey(true);
        }
    }

    

}
