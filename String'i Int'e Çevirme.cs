using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Bir İfadeyi İnt'e Çevirme
            int a = 0;
            int carpim = 1;
            string s = "123456";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                a = a + ((byte)s[i] - (byte)'0') * carpim;
                carpim = carpim * 10;

            }
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
