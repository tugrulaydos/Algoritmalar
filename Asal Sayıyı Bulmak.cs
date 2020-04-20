using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir Sayının Asal Olup Olmadığını Bulan Program
            Console.Write("Bir Sayı Giriniz:");
            int sayi = Int16.Parse(Console.ReadLine());
            bool asalmi=true;
            for(int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalmi = false;
                    break;
                }               

            }
            if (asalmi)
            {
                Console.Write("Asaldır");
            }
            else
            {
                Console.Write("Asal Değildir");
            }
        }
    }
}
