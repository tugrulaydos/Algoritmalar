using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;

namespace Linked_List1
{
    class tekli 
    {
        public tekli next;
        public int data;
    }

    
    class Program
    { 
        static void Main(string[] args)
        {
            //10 Bloktan Oluşan Linked List Oluşturma  

            tekli head = null;

            tekli last = null;

            tekli t = null;

            for(int i = 0; i < 10; i++)
            {
                t = new tekli();

                t.data = i;

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

            }

            tekli iter = head;

            while (iter != null)
            {
                Console.Write(iter.data+"\t");
                iter = iter.next;
            }

            Console.ReadLine();
            

        }
    }
}
