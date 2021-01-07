using System;

namespace ConsoleApp35
{
    class Tekli
    {
        public int data;

        public Tekli next;

    }
    class Program
    {
        public static void EkranaYaz(Tekli x)
        {
            while (x != null)
            {
                Console.WriteLine(x.data);
                x = x.next;
            }
            
        }
        static void Main(string[] args)
        {
            //Tekli Linked List içerisinden data degeri 23 olan bloğu siliniz.

            Tekli head = null;
            Tekli last = null;

            for(int i = 0; i < 100; i++)
            {
                head = new Tekli();

                head.data = i;

                head.next = last;

                last = head;
               
            }

            
            Tekli temp = head;          

            while (temp.next.next != null)
            {
                if (temp.next.data == 23)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }

            }

            EkranaYaz(head);
            Console.ReadLine();    
            

           
            
             
        }
    }
}
