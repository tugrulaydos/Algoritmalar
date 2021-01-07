using System;
using System.Collections.Generic;

namespace ConsoleApp35
{
    class Tekli
    {
        public int data;
        public Tekli next;
    }
    class Program
    {       

        public static void Ekrana_Yaz(Tekli x)
        {
            while (x != null)
            {
                Console.WriteLine(x.data);
                x = x.next;
            }
        }
        static void Main(string[] args)
        {
            //Tekli Linked List'in Son Elemanını Listeden Düşünüz.

            Tekli head = null;
            Tekli last = null;

            for(int i = 0; i < 100; i++)
            {
                Tekli t = new Tekli();
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

          

            Tekli temp = head; //Son elemanı listeden düşmak için temp son elemandan önceki elemana bakmalıdır.

            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            temp.next = null; //Son elemanı listeden düşmüş olduk.

            Ekrana_Yaz(head);

            Console.ReadLine();






          



        }
    }
}
