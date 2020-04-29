using System;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir Sayının Msb(Most Significant Bit-En Yüksek Seviyeli Bit)10 Bitini B Sayısına Ekleyelim.
            uint A = 0xff00ff00;
            uint B = 0;
            B = A | B; // B = A Demektir
            B = B >> 22;
            Console.WriteLine(B);
            Console.ReadLine();

        }
    }
}
