using System;

namespace ConsoleApp51
{
    class Program
    {
        static uint mask = 1;
        public static uint Hesapla(uint a)
        {
           
            if (mask==0)
            {
                return a;
            }
            if ((a & mask) != 0)//Buradaki Bit 1'dir 0 Yapılacak
            {
                a = a & ~mask;
            }
            else   //Buradaki Bit 0'dır 1 Yapılacak
            {
                a = a | mask;
            }
            mask = mask << 1;
            return Hesapla(a);        
            

        }
        static void Main(string[] args)
        {
            //Bir Sayı'nın Değilini Alma(Recursive)
            Console.WriteLine(Hesapla(0xffffffed));
            Console.ReadLine();


           
        }
    }
}
