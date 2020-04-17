using System;

namespace ConsoleApp10
{
    // e^x = 1+x+x^2/2!+x^3/3!+x^4/4!......
    class Program
    {
        static double e = 1;
        static int f = 1;
        static int ex = 1;
        public static double hesapla(int x,int i)
        {
            if (i == 1)
            {
                ex = x;
            }
            else
            {
                ex = x * ex;
            }
            
            if (i == 10)
            {
                return e;
            }
            f = f * i;
            e += (double)ex / f;
            return hesapla(x,i+1);
            

        }
        static void Main(string[] args)
        {
            Console.Write("X Değerini Giriniz:");
            int x = Int16.Parse(Console.ReadLine());
            Console.Write(hesapla(x,1));
            Console.ReadLine();
            
              
               
            

        }
    }
}
