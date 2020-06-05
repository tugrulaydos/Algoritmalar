using System;

namespace ConsoleApp103
{
    class Program
    {     
        static void Main(string[] args)
        {
            //5 adet sort edilmiş dizi var bunları nasıl sıralı tek bir dizi haline getiriniz. 
            int n = 5;
            int[,] merge = new int[n,100];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    merge[i, j] = j * (i + 1);
                }

            }            
            int[] p = new int[n];
            int eke = 0;
            int eki = 0;
            int[] sonuc = new int[n*100];
            int sonucadres = 0;
            while(sonucadres < 500)
            {
                eke = 1000000;
                for(int i = 0; i < n; i++)
                {
                    if (p[i] >= 100) { continue; }

                    if (merge[i, p[i]] < eke)
                    {
                        eke = merge[i, p[i]];
                        eki = i;
                    }               

                }
                sonuc[sonucadres++] = merge[eki,p[eki]];
                p[eki]++;
            }

            //Birleştirilmiş Diziyi Print Ediyoruz
            for(int i = 0; i < sonucadres; i++)
            {
                Console.WriteLine(sonuc[i]);
            }
            Console.ReadLine();


                                                                    

            
        }
    }
}
