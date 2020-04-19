using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            //int İfadeyi String'e Çevirme

            int a = 9346;
            string s = "";
            while(a > 0)
            {
                s = (char)(a%10 + (byte)'0') + s;
                a = a / 10;               
            }
            Console.Write(s);
            Console.ReadLine();

        }
    }
}
