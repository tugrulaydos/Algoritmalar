using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //pi = 4*(1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11.......

            double pi = 1;
            int[] dizi = new int[2]; //- + kontrolu için tanımladık
            dizi[0] = 1;
            dizi[1] = -1;
            // -3  +5  -7  +9  -11 
            // -2  +4  -6  +8  -10
            // -1  +2  -3  +4  -5
            for(int i = 3; i < 2050; i+=2)
            {
                pi += (double)1 / i * dizi[(i - 1) / 2 % 2];
                
            }
            Console.WriteLine(4*pi);
            Console.ReadLine();


            
        }
    }
}
