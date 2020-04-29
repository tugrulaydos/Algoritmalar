using System;

namespace Fibonacci_Recursive_
{
    class Program
    {
        public static int fibonacci(int x,int y,int i)
        {
           
            if (i == 0)
            {
                return y;
            }

            return fibonacci(y, x + y, i - 1);

        }
        static void Main(string[] args)
        {
            Console.Write("Terim Sayısını Giriniz:");
            int terim = Int16.Parse(Console.ReadLine());
            for(int i = 0; i < terim; i++)
            {
                Console.Write(fibonacci(0, 1, i)+"  ");
            }
            Console.ReadLine();
            
        }
    }
}
