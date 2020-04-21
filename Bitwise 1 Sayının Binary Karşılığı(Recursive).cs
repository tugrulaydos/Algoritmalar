using System;

namespace ConsoleApp39
{
    class Program
    {
        //Sayıyı Binary Karşılığında Recursive Metotla Yazmak 
        public static string Binary(uint sayi)
        {
            
            uint mask = 1;
            if (sayi == 0)
            {
                return "";
            }
            if ((sayi & mask) == 1)
            {
                return Binary(sayi >> 1) + "1"; 
            }
            else
            {
                return Binary(sayi >> 1) + "0";
            }
        }

        static void Main(string[] args)
        {
            Console.Write(Binary(0xfe));
            Console.ReadLine();

        }
    }
}
