using System;
using System.Diagnostics;

namespace ConsoleApp93
{
    class Program
    {
        public static int altkumetoplam(int[] dizi,int kontrol)
        {          
            
            int mask=1;
            int toplam=0;           
            for(int j = 0; j < dizi.Length; j++)
            {
                
                if ((mask & kontrol) != 0)
                {
                    toplam += dizi[j];
                }
                mask = mask << 1;
            }
            if (kontrol == Math.Pow(2, dizi.Length))
            {
                return 0;
            }
            if (toplam == 20)
            {
                return 1 + altkumetoplam(dizi, kontrol + 1); 
            }
            else
            {
                return 0 + altkumetoplam(dizi, kontrol + 1);
            }

        }
        static void Main(string[] args)
        {
            //Elamanları Toplamları 20 Olan Kaç AltKüme Vardır.
            int[] eleman = new int[13]; 
            for(int i = 0; i < 13; i++)
            {
                eleman[i] = i + 1;
            }
            int sonuc = altkumetoplam(eleman, 0);
            Console.WriteLine(sonuc);
            Console.ReadLine();
            
          





        }
    }
}
