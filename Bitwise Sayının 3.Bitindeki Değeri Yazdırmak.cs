using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Sayısının 3.Bitindeki Değeri Ekrana Yazırma

            uint a = 0xffffffef;

            uint mask = 4;

            a = a & mask;

            if (a > 0) { Console.WriteLine("1"); }

            else { Console.WriteLine("0"); }

            Console.ReadLine();

        }
    }
}
