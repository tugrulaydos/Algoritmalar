using System;

namespace LinkedList_1_Recursive
{
    class tekli
    {
        public tekli next;
        public int data;
    }
    class Program
    {
        public static void CreateBlock(tekli t, tekli head, tekli last, int data)
        {
            if(data > 10)
            {
                return;
            }

            t.data = data;
            if (head == null)
            {
                head = t;
                last = t;

            }
            else
            {
                last.next = t;
                last = t;
            }
            t = new tekli();

            CreateBlock(t, head, last, data + 1);

        }

        public static void PrintSolution(tekli head)
        {
            if (head == null)
            {
                return;
            }

            Console.Write(head.data+" ");
            PrintSolution(head.next);
                

        }
        static void Main(string[] args)
        {
            tekli t = new tekli();

            tekli head = null;
            tekli last = null;

            CreateBlock(t, head, last,0);

            tekli iter = t;

            PrintSolution(iter);

            Console.ReadLine();
           
        }
    }
}
