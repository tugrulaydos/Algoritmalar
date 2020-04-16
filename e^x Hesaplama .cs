using System;

namespace ConsoleApp11
{
    class Program
    {           
                
        static void Main(string[] args)
        {

            //e^x = 1 + x + x^2/2! + x^3/3! + x^4/4!..... 

            Console.Write("X Degerinini Giriniz:");
            int x = Int16.Parse(Console.ReadLine());
            double e = 1;
            int ex = x;
            int f = 1;
            for (int i = 2; i < 8; i++)
            {
                e += (double)ex / f;
                ex = x * ex;
                f = f * i;
            }
            Console.WriteLine(e);
            Console.ReadLine();




        }
    }
}
