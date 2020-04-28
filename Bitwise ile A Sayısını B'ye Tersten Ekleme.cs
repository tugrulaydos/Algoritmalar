using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Sayısının Bitlerini B Sayısına Tersten Eklemek
            //Örneğin: A=1010 --> B=0101 Olmalıdır.

            uint A = 0xff00ff00;
            uint B = 0;
            uint kontrol = 0x00ff00ff;
            uint mask = 0x80000000;
            uint mask2 = 1;
            for(int i = 0; i < 32; i++)
            {
                if ((A & mask) != 0) //Buradaki Bit 1'dir.
                {
                    B = B|mask2;
                }
                else //Buradaki Bit 0'dır.
                {
                    B = B & ~mask2; 
                }
                mask = mask >> 1;
                mask2 = mask2 << 1;   
            }
            Console.WriteLine(A);
            Console.WriteLine(kontrol); // Kontrol ve B Eşitse Program Doğru Çalışıyodur.
            Console.WriteLine(B);            
            Console.ReadLine();
                        
            
        }
    }
}
