using System;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sayının Sağdan 2.Hex Değerini 1 Artırma

            uint a = 0xff00ff00;
            Console.WriteLine(a);
            uint b = a;
            b = b & 0x000000f0;
            b = b + 0x10;
            a = a & 0xffffff0f;
            a = a | b;
            Console.WriteLine(a);
            Console.ReadLine();          

        }
    }
}
