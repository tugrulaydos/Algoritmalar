using System;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alt Küme Elemanları Toplamı 20 Olan Kaç  Adet Altküme Vardır.

            int[] s = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int adet = 0;
            int toplam = 0;
            int mask;
            for(int i = 0; i < Math.Pow(2, s.Length); i++)
            {
                mask = 1;
                for(int j = 0; j < s.Length; j++)
                {
                    if ((i & mask) != 0)
                    {
                        Console.Write(s[j]);
                        toplam = toplam + s[j];

                    }
                    mask = mask << 1;
                }
                Console.WriteLine();
                if (toplam == 20)
                {
                    adet++;
                }
                toplam = 0;
            }
            Console.WriteLine("\n{0} Adet Vardır",adet);

            Console.ReadLine();



           
            
        }
    }
}
