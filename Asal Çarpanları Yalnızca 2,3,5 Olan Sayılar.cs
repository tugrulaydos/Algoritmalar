using System;

namespace ConsoleApp72
{
    class Program
    {
        public static bool ugly(int sayi)
        {
            while (sayi % 2 == 0)
            {
                sayi = sayi / 2;
            }
            while (sayi % 3 == 0)
            {
                sayi = sayi / 3;
            }
            while (sayi % 5 == 0)
            {
                sayi = sayi / 5;
            }
            return sayi == 1 ? true : false;
        }
        static void Main(string[] args)
        {
            //Asal Çarpanları Yalnızca 2,3 ve 5 Olan Sayılardan İlk 25 Tanesini Bulunuz(Ugly Sayıları)
            int sayi = 1;
            int sayac = 0;
            while (true)
            {
                sayi++;
                if (ugly(sayi)) { Console.WriteLine(sayi); sayac++; }

                if (sayac == 25) { break; }

            }

            
        }
    }
}
