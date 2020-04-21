using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir Sayının Binary Karşılığını Yazdırmak 

            uint sayi = 0xff0000ea;
            string s = "";
            uint mask = 1;
            while (sayi > 0)
            {
                if ((sayi & mask) == 1)
                {
                    s = "1" + s;
                }
                else
                {
                    s = "0" + s;
                }
                sayi = sayi >> 1;                
            }

            Console.Write(s);
            Console.ReadLine();
            
        }
    }
}
