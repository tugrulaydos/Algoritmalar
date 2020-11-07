using System;
using System.Globalization;

namespace BackTracking_2_NQueen_Problem
{
    class Program
    {
        public static int N = 12;//Tahta'nın Boyutu 

        public static void EkranaBas(int [,] tahta)//Sonucu Ekrana Bas
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(" "+tahta[i,j]);
                }
                Console.WriteLine();
            }

        }

        public static bool Guvenlimi(int[,] tahta,int satir,int sutun)
        {
            for (int i = 0; i < sutun; i++)
            {
                if (tahta[satir, i] == 1) //Satir için kontrol yapar 
                {
                    return false;
                }
            }

            for(int i = satir,j = sutun;i >= 0 && j >= 0; i--, j--) //Üst Köşegen Kontrolü yapıyoruz 
            {
                if (tahta[i, j] == 1)
                {
                    return false;
                }

            }

           

            for(int i = satir, j = sutun; i < N && j >= 0; i++, j--) //Alt Köşegen Kontrol edilir
            {
                if (tahta[i, j] == 1)
                {
                    return false;
                }
            }

            return true;

        }

        public static bool Cozum(int[,]tahta,int sutun)
        {
            if(N == sutun)
            {
                return true;
            }
            for(int i = 0; i < N; i++)
            {
                if (Guvenlimi(tahta, i, sutun))
                {
                    tahta[i, sutun] = 1;

                    if (Cozum(tahta, sutun + 1))
                    {
                        return true;
                    }

                    tahta[i, sutun] = 0;//Backtrack işlemi
                }

            }

            return false;
        }

       
        
        static void Main(string[] args)
        {
            //N*N'lik bir satranç tahtasında N vezir birbirini tehdit etmeden dizilebilir mi?
            //Program yalnızca bir çözümü ekrana basar farklı çözümler mevcuttur.

            int[,] tahta = new int[N, N];

            if (Cozum(tahta, 0))
            {
                EkranaBas(tahta);
            }
            else
            {
                Console.Write("Çözüm Yoktur");
            }


            Console.ReadLine();
           
        }
    }
}
