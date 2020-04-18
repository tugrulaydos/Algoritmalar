using System;

namespace ConsoleApp16
{
    class Program
    {
        public static void Hesapla(int sayi,ref int toplam)
        {
            
            if (sayi == 0)
            {
                return; //Metottan çıkar
            }

            toplam = toplam + sayi % 10;
            Hesapla(sayi / 10,ref toplam);
             
        }

        static void Main(string[] args)
        {
            int q = 0;
            Console.Write("Sayı Giriniz:");
            int sayi = Int16.Parse(Console.ReadLine());
            Hesapla(sayi,ref q);
            Console.Write("Rakamları Toplamı:{0}", q);
            Console.ReadLine();


            
        }
    }
}
