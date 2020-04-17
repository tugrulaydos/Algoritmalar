using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            //sinx = x - x^3/3! + x^5/5! - x^7/7! + x^9/9!.... 
            //Değerler Radyan Cinsinden Yazılmalı
            Console.Write("X Değerini Giriniz:");
            double x = Convert.ToDouble(Console.ReadLine());
            double ex = x;
            double sinx = 0;
            int f = 1;
            int[] faktoriyel = new int[10];
            int kontrol = 1;
            for(int i = 1; i < faktoriyel.Length; i++)
            {
                f = f * i;
                faktoriyel[i] = f;
               
            }
            for(int i = 1; i < 10; i += 2)
            {

                ex = x * x * ex;
                sinx += (double)ex / faktoriyel[i]*kontrol;
                kontrol = kontrol * -1;

            }
            Console.WriteLine(sinx);
            Console.ReadLine();
           
        }
    }
}
