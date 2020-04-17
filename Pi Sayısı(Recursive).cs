using System;

namespace ConsoleApp14
{
    class Program
    {
        static int kontrol = -1;
        public static double pi(double p , int i)
        {
            
            if (i > 2000)
            {
                return p;
            }
            p += (double)1 / i * kontrol;

            kontrol = kontrol * -1;

            return pi(p, i + 2);

        }
        static void Main(string[] args)
        {
            Console.Write(4 * pi(1,3));
            Console.ReadLine();

            
        }
    }
}
