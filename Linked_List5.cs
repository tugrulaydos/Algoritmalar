using System;

namespace Linked_List5
{
    class tekli
    {
        public tekli next;
        public int data;

    }

    class Program
    {
        public static void PrintSolution(tekli t) //Sonucu Ekrana Bas
        {
            while (t != null)
            {
                Console.Write(t.data + " ");
                t = t.next;
            }


        }

        public static void ElemanEkle(int sira,int eleman,tekli t)
        {
            tekli temp = new tekli(); //Eklenecek yeni kutumuz

            temp.data = eleman; // datasını kullanıcının girdiği değere eşitledik

            for(int i = 0; i < sira-1; i++)
            {
                t = t.next; //hangi elemandan sonra ekleyeceksek orayı point etmeli                
            }

            temp.next = t.next;
            t.next = temp;          

            

        }
        static void Main(string[] args)
        {

            tekli head = null;
            tekli last = null;
            Console.Write("Eleman Eklenmeden Önce: ");
            for(int i = 0; i < 10; i++)
            {
                head = new tekli();
                head.data = i;

                head.next = last;
                last = head;                
            }
            PrintSolution(head);

           

            Console.Write("\nAraya Eklenecek Elemanı Giriniz:");
            int eleman = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaçıncı Elemandan Sonra Eklensin:");
            int sira = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEleman Ekledikten Sonra: ");
            ElemanEkle(sira, eleman, head);
            PrintSolution(head);
            Console.ReadLine();
          



            

            
            
            
        }
    }
}
