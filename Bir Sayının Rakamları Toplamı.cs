using System;

namespace Bir_Sayının_Rakamları_Toplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Herhangi Bir Sayının Rakamları Toplamını Bulan C# Programı
            int a = 9831498;
            int toplam = 0;
            while (a > 0)
            {
                toplam = toplam + a - a / 10 * 10; //toplam + a % 10;
                a = a / 10;
            }
            Console.Write(toplam);
            Console.ReadLine();
           
        }
    }
}
