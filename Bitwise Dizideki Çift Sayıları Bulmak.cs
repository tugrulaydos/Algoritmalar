using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 Elemanlı Dizi'nin Elemanlarından Kaç Tane Çift Sayı Vardır.

            int[] dizi = new int[100];

            int toplam = 0;
            
            for (int i = 0; i < 100; i++)
            {
                dizi[i] = i;
                if ((dizi[i] & 1) == 0)
                {
                    toplam++;
                }
            }

            Console.WriteLine("{0} Adet Çift Sayı Vardır", toplam);
            Console.ReadLine();

           


        } 
    }
}
