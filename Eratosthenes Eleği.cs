using System;

namespace Eratosthenes_Eleği
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erotosthenes eleği Asal sayı Bulmak için geliştirilmiş bir yöntemdir.
            //Aşağıdaki pogramda 0 ile 1000 arasındaki asal sayıları bulup ekrana yazdıracağız 

            int AsalSayac = 0;

            int[] dizi = new int[1001]; //0 ile 1000 arasında 1001 adet eleman vardır.

            for(int i = 0; i <= 1000; i++)
            {
                dizi[i] = 1;
            }

            dizi[0] = 0;
            dizi[1] = 0;

            //Butun Elemanları 1'lerden olusan bir dizi olusturduk amaç Asal sayı olmayan dizi indislerini 0 yapmaktır.
            //Bu sayede en son yalnızca Asal sayı olan dizi indisleri 1 olacaktır.
            //Örneğin 2 için 2'nin katları(2 hariç) yani  4 6 8 10 12 14 16.....1000.

            for(int i = 2; i <= 100; i++)
            {
                for(int a = 2 * i; a <= 1000; a += i)
                {
                    dizi[a] = 0;
                }
            }
            //Aşağıda belirtecleri asal olan elemanların degerleri 1 olarak kalır.
            for(int i = 0; i <= 1000; i++)
            {
                Console.Write("dizi[{0}]-->{1}{2}", i, dizi[i],
                              i % 2 == 0 ? '\t' : '\n');
                if (dizi[i] == 1)
                {
                    AsalSayac++;
                }
            }

            Console.Write("\n0 ile 1000 Arasında {0} Adet Asal Sayı Vardır", AsalSayac);
            Console.ReadLine();
            
        }
    }
}
