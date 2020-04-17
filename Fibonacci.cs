using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen Değere Kadar Fibonacci Serisi Oluşturan Program
            Console.Write("Terim Sayısı:");
            int sayi = Int16.Parse(Console.ReadLine());
            int s1 = 0;
            int s2 = 1;
            int s3;
            Console.WriteLine("\n");            
            Console.Write("{0}\t{1}\t", s1, s2);
            for(int i = 2; i < sayi; i++)
            {
                s3 = s1 + s2;
                s1 = s2;
                s2 = s3;
                Console.Write("{0}\t", s3);              

            }
            Console.ReadLine();
        }
    }
}
