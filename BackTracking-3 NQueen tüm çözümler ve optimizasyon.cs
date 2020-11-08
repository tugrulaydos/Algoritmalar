using System;

namespace ConsoleApp20
{
    class Program
    {
        public static int N = 8;
        public static int k = 1;


        //Yerleştirilen her vezir için tehdit altında olup olmadığını kontrol etmeiyiz
        //Guvenlimi fonksiyonu yazmaya gerek kalmadı.
        //satir sutun toplamı sag kosegeni verir.
        //satir sutun farki sol kosegeni verir.

        public static int[] sol = new int[2 * N - 1 + N - 1]; //Sol Kosegen-> 2n -1 adet sol kosegen vardir fakat dizi'nin içerisi negatif olamaz N-1 adım öteledik 

        public static int[] sag = new int[2 * N - 1]; //Sağ Kösegen->  2n-1 adet sağ kosegen vardir

        public static int[] satir = new int[N]; //N adet satir vardır

        //kontrol 3 durum için yapılmalıdır.

        public static void EkranaYaz(int[,] tahta)
        {
            Console.WriteLine("{0}.Çözüm",k++);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(" " + tahta[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static bool Cozum(int[,] tahta, int sutun)
        {
            if (sutun >= N)
            {
                EkranaYaz(tahta);
                return true;
            }

            bool sonuc = false;

            for (int i = 0; i < N; i++)
            {
                if (sol[i-sutun+N-1] != 1 && sag[i + sutun] != 1 && satir[i] != 1)
                {
                    sol[i-sutun+N-1] = sag[i + sutun] = satir[i] = 1;
                    tahta[i, sutun] = 1;

                    sonuc = Cozum(tahta, sutun + 1) || sonuc;                       
                    

                    sol[i-sutun+N-1] = sag[i + sutun] = satir[i] = 0; //Backtrack
                    tahta[i, sutun] = 0;
                }
            }
            return sonuc;

        }
        static void Main(string[] args)
        {
            int[,] tahta = new int[N, N];

            Cozum(tahta, 0);

            Console.ReadLine();


        }
    }
}

