using System;

namespace Linked_List3
{
    class tekli
    {
        public tekli next;
        public int data;
    }

    
    class Program
    {
        public static void PrintSolution(tekli head) //Linked Listi Ekrana Print etmek
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }

        }
        static void Main(string[] args)
        {
            //Dizi'nin Elemanlarını Linked List'e atamak

           int[] dizi = new int[100];

           for(int i = 0; i < dizi.Length; i++)
           {
                dizi[i] = i;
           }

            tekli head = null;
            tekli last = null;

            for(int i = dizi.Length-1; i >= 0; i--)
            {
                head = new tekli();

                head.data = dizi[i];

                head.next = last;

                last = head;

            }
            PrintSolution(head);            
           
        }
    }
}
