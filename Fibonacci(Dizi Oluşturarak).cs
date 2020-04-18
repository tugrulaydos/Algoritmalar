using System;

namespace Fibonacci2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Terim Sayısını Giriniz:");
            int terim = Int16.Parse(Console.ReadLine());
            int[] fibo = new int[terim];
            fibo[0] = 0;
            fibo[1] = 1;
            for(int i = 2; i < fibo.Length; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];            
            }
            for(int j = 0; j < fibo.Length; j++)
            {
                Console.Write(fibo[j] + "  ");

            }
            Console.ReadLine();

            
        }
    }
}
