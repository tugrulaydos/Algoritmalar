using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 Elemanlı Bir Dizideki Sayıların 5.Bitlerindeki Değerleri Toplayıp Ekrana Yazdırmak

            uint[] x = new uint[100];
          
            uint mask = 0x10;

            uint toplam = 0;
            
            for(int i = 0; i < 100; i++)
            {
                if ((x[i] & mask) != 0)
                {
                    toplam++;
                }
                
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
           
        }
    }
}
