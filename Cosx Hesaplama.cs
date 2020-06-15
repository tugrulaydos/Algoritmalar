using System;

namespace ConsoleApp119
{
    class Program
    {
        public static double faktoriyel(int data)
        {
            double sonuc = 1;
            while (data > 1)
            {
                sonuc = sonuc * data;
                data--;
            }
            return sonuc;
            
        }
        static void Main(string[] args)
        {
            //cosx = 1 - x^2/2! + x^4/4! - x^6/6! + x^8/8!.....

            Console.Write("X değerinin Giriniz(Radyan Cinsinden):");
            double x = Convert.ToDouble(Console.ReadLine());
            double ex = x * x;
            double sonuc = 1;
            int[] dizi = new int[3];
            dizi[0] = 1;
            dizi[2] = -1;
            
            for(int i = 2; i < 8; i += 2)
            {
                sonuc += ex / faktoriyel(i) * dizi[i % 4];
                ex = x * x * ex;                
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();


           
        }
    }
}
