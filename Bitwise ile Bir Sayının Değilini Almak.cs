using System;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bitwise ile Bir Sayının Değilini Alma İşlemi
            uint a = 0xffffffed; //Değili-->0x12 (18)
            uint mask = 1;
            uint mask2 = 0xfffffffe;
            for(int i = 0; i < 32; i++)
            {
                if ((a & mask) != 0) //Buradaki Bit 1'dir 0 Olacak
                {
                    a = a & mask2; //a = a & ~mask --> Bu Şekilde de olur mask2 tanımlamaya gerek yok
                }
                else //Buradaki Bit 0'dır 1 Olacak
                {
                    a = a | mask;
                }
                mask = mask << 1;
                mask2 = mask2 << 1;
                mask2 += 1; 
            }
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
