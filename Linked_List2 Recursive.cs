using System;

namespace Linked_List2_Recursive
{
    class tekli
    {
       public tekli next;
       public int data;
    } 
    

    class Program
    {
        static tekli head=null;
        static tekli last=null;
        

        public static void CreateBlock(int data)
        {
            if (data > 10)
            {
                return;
            }

            head = new tekli();
            head.data = data;

            head.next = last;

            last = head;
            CreateBlock(data + 1);

        }

        public static void PrintSolution(tekli t)
        {
            if (t == null)
            {
                return;
            }
            Console.Write(t.data + "\t");
            PrintSolution(t.next);

        }
        static void Main(string[] args)
        {

            CreateBlock(0);
            PrintSolution(head);

            Console.ReadLine();
            
            
        }
    }
}
