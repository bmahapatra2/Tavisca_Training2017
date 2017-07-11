using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_Implementation
{
    class queue
    {
        int front = -1, rear = -1;
        int[] Queue = new int[5];


        static void Main(string[] args)
        {
            queue p = new queue();



            int ch = 0;
            while (ch <= 4)
            {
                Console.WriteLine("\n enter your choice \n 1 for push \n 2 for pop \n 3 for display");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)

                {
                    case 1:
                        Console.WriteLine("enter element to insert");
                        int item = Convert.ToInt32(Console.ReadLine());
                        p.enqueue(item);

                        break;
                    case 2:
                        p.dqueue();

                        break;
                    case 3:
                        p.display();

                        break;




                    default:
                        Environment.Exit(0);
                        break;
                }
                Console.ReadKey(true);
            }
        }

        void enqueue(int item)
        {

            if (rear < 4)
            {

                if (front == -1)
                {
                    front = 0;
                    rear = 0;
                    Console.WriteLine("Element inserted:");
                }
                else
                {
                    rear = rear + 1;
                    Queue[rear] = item;
                    Console.WriteLine("element inserted");
                }

            }
            else
            {
                Console.WriteLine("Queue is full");

            }
        }
        void dqueue()

        {
            int item;
            if (front != -1)
            {
                item = Queue[front];
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                    Console.WriteLine("Element deleted ");
                }
                else
                {
                    front = front + 1;
                    Console.WriteLine("deleted item is ", item);

                }
            }
            else
            {
                Console.WriteLine("queue is empty");
            }
        }
        void display()
        {

            int i;
            for (i = front; i < rear; i++)
            {
                Console.WriteLine(Queue[i]);
            }

        }
    }
}

