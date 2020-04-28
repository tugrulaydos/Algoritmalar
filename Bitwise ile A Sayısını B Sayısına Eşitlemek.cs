using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            //A ile B Sayısını = Operatoru Kullanmadan Eşitle
            //Yani A Sayısının Bitlerini B'ye Yapıştır
            uint a = 0xed;
            uint b = 14214123;
            uint mask = 1;
            for(int i=0 ; i < 32 ; i++)
            {
               
                if ((a & mask) != 0)//Buradaki Bit 1'dir.
                {
                    b = b | mask;
                }
                if ((a & mask) == 0)//Buradaki Bit 0'dır.
                {
                    b = b & ~mask;
                }
                mask = mask << 1;
            }
            Console.WriteLine(b);
            Console.ReadLine();


            
        }
    }
}
