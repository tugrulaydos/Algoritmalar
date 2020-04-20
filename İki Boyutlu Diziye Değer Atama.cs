using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            // iki Boyutlu Bir Diziye Rastgele Değer Atayıp Elemanlarını Toplayan Algoritma
            int[,] dizi = new int[5,5];
            Random rnd = new Random();
            int toplam = 0;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    dizi[i, j] = rnd.Next(1, 10);
                    toplam = toplam + dizi[i, j];
                    Console.Write(dizi[i, j] + "  ");
                }
                Console.WriteLine();
            
            }
            Console.WriteLine("\n");
            Console.Write("Elemanları Toplamı:{0}", toplam);
            Console.ReadLine();

            
            
        }
    }
}
