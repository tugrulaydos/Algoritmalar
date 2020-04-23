using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            uint A = 5;
            uint B = 4;
            for(int i = 0; i < 32; i++)
            {
                if ((A & 0x80000000) == (B & 0x80000000))
                {
                    A = A << 1;
                    B = B << 1;
                }
                else
                {
                    if((A & 0x80000000) != 0)
                    {
                        Console.WriteLine("A Sayısı Büyüktür");
                    }
                    if((B & 0x80000000) != 0)
                    {
                        Console.WriteLine("B Sayısı Büyüktür");
                    }
                    break;

                }
            }
            Console.ReadLine();
            
            
        }
    }
}
