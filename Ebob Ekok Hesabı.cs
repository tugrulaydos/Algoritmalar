using System;

namespace ConsoleApp29
{
    class Program
    {
        public static int Ebob(int sayi1,int sayi2)
        {
            int kucuk = sayi1;
            int obeb = 1;
            if (sayi1 > sayi2)
            {
                kucuk = sayi2;

            }
            for(int i=kucuk;i > 0; i--)
            {
                if (sayi1 % i == 0 & sayi2 % i == 0)
                {
                    obeb = i;
                    break;
                }
            }
            return obeb;
        }

        public static int Ekok(int sayi1,int sayi2)
        {
            int buyuk = sayi2;
            int okek = 0;
            if (sayi2 < sayi1)
            {
                buyuk = sayi1;
            }
            for(int i = buyuk; i <= sayi1 * sayi2; i++)
            {
                if (i % sayi1 == 0 & i % sayi2 == 0)
                {
                    okek = i;
                    break;
                }
                
            }
            return okek;
        }

        static void Main(string[] args)
        {
            //Ebob ve Ekok Hesaplama
            Console.WriteLine(Ebob(216,144));
            Console.WriteLine(Ekok(91, 13));
            Console.ReadLine();

            //Not: Ekok = (sayıların Çarpımı)/Ebob   
            

        }
    }
}
