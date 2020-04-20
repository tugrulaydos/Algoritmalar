using System;

namespace ConsoleApp30
{
    class Program
    {
        public static bool Asal(int s)
        {
            bool asalmi = true;
            for(int i = 2; i < s; i++)
            {
                if (s % i == 0)
                {
                    asalmi = false;
                    break;
                }
            }
            return asalmi;


        }
        static void Main(string[] args)
        {
            //Girlen Sayıdan Sonraki 5 Asal Sayıyı Bulan Program
            Console.Write("Bir Sayı Giriniz:");
            int sayi = Int16.Parse(Console.ReadLine());
            int sayac = 0;
            while (sayac < 5)
            {
                sayi++;

                if (Asal(sayi))
                {
                    sayac++;
                    Console.WriteLine(sayi);

                }
            }
            Console.ReadLine();


        }
    }
}
