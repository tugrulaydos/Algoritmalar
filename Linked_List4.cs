using System;

namespace Linked_List4
{
    class tekli 
    {
        public tekli next;
        public int data;
    }
    class Program
    {
        public static void PrintSolution(tekli head)
        {
            while (head != null)
            {
                Console.Write(head.data+"\t");
                head = head.next;
            }

        }
        public static int UzunlukBul(tekli head)
        {
            if (head == null)
            {
                return 0;
            }

            return 1 + UzunlukBul(head.next);


        }
        static void Main(string[] args)
        {
            //Linked listteki elemanları diğer linked list'e atamak

            tekli head1 = null;            
            tekli last1 = null;
            
            for(int i = 0; i < 10; i++)
            {
                head1 = new tekli();
                head1.data = i;

                head1.next = last1;
                last1 = head1;                     
            }
            //ilk linked listi oluşturduk şimdi buradaki degerleri 2.linked liste atalım
            //Lined list'in uzunluğunu ve başlangıç degerini bilmemiz gerekli bilmemiz gerek

            tekli head2 = null;
            tekli last2 = null;

            tekli iter = head1;

            int uzunluk = UzunlukBul(head1);
            
            for(int i=0; i < uzunluk; i++)
            {
                head2 = new tekli();
                head2.data = iter.data;

                head2.next = last2;
                last2 = head2;

                iter = iter.next;

            }

            PrintSolution(head2);
            Console.ReadLine();




            
        }
    }
}
