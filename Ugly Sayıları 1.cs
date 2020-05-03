using System;

namespace ConsoleApp73
{
    class Program
    {
        public static int bolum(int sayi,int bolum)
        {
            while (sayi % bolum == 0) { sayi = sayi / bolum; }

            return sayi;
        }
        public static bool ugly(int sayi)
        {
            sayi = bolum(sayi,2);
            sayi = bolum(sayi,3);
            sayi = bolum(sayi,5);

            if (sayi == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            //Yalnızca 2,3 veya 5 Sayılarına Bölünen Sayılar(Ugly Sayıları)
            //ilk 50 Tanesi 
            int uglyadet = 0;
            int sayi = 1;
            while (true)
            {
                sayi++;

                if (ugly(sayi)) { Console.WriteLine(sayi); uglyadet++; }

                if (uglyadet == 50) { break; }

            }           

            
        }
    }
}
