using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Bir İfadede En Çok Kullanılan Harfin Kaç Defa Kullanıldığını Bulan Program

            string s = "faaffggafcewpffffdsa";
            int[] dizi = new int[30];
            for(int i = 0; i < s.Length; i++)
            {
                dizi[s[i] - (byte)'a']++;
            }
            int eb = 0;
            for(int j = 0; j < dizi.Length; j++)
            {
                if (eb < dizi[j])
                {
                    eb = dizi[j];
                }
            }
            Console.WriteLine("En Çok Kullanılan Harf {0} Defa Kullanılmıştır", eb);
            Console.ReadLine();

        }
    }
}
