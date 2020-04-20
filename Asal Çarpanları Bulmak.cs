using System;

namespace ConsoleApp27
{
    class Program
    {
        public static bool Asal(int sayi)
        {
            bool asalmi = true;
            for(int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalmi = false;
                    break;
                }

            }
            return asalmi;
        }
        static void Main(string[] args)
        {
            //Bir Sayının Asal Çarpanlarını Bulmak
            Console.Write("Bir Sayı Giriniz:");
            int sayi = Int32.Parse(Console.ReadLine());
            for(int i = 2; i < sayi; i++)
            {
                if (Asal(i))
                {
                    if (sayi % i == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
              
            }
            Console.ReadLine();


            

        }
    }
}
