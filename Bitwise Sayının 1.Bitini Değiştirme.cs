using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Sayısının 1.Bitini Diğer Bitlere Zarar Vermeden Değiştiriniz.

            Console.Write("A Sayısını Giriniz:");

            uint a = UInt16.Parse(Console.ReadLine());           

            uint mask1 = 0xfffffffe;
            

            if (a % 2 == 0)
            {               
                a = a | ~mask1; 
            }
            else
            {
                a = a & mask1;
            }
           
            Console.WriteLine(a);

            Console.ReadLine();

                      




            
        }
    }
}
