using System;

namespace Linked_List2
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
            //10 adet blok oluşturma
            tekli head = null;
            tekli last = null;

            for(int i = 0; i < 10; i++)
            {
                head = new tekli();
                head.data = i;

                head.next = last;
                last = head;
            }

            tekli temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + "\t");
                temp = temp.next; 
            }

            Console.ReadLine();




                 

                        

        }
    }
}
