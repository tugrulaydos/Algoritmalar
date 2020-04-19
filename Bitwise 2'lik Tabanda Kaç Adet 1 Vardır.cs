using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir Sayının 2'lik Sayı Sistemindeki Karşılığında Kaç Adet 1 Vardır

            uint a = 0xabcdef12;
            uint mask = 1;
            int toplam = 0;
            for(int i = 0; i < 32; i++)
            {
                if ((a & mask) == 1)
                {
                    toplam++;
                }
                a = a >> 1; //mask = mask<<1;
            }
            Console.Write(toplam);
            Console.ReadLine();

        }
    }
}
