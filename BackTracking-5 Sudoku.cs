using System;

namespace BackTracking_5_Sudoku
{
    class Program
    {
        public static int N = 9; //Sudaoku 9 X 9 Bir Sudoku Olacak 
        public static void EkranaBas(int[,] Sudoku) //Sonucu Ekrena Bas
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(Sudoku[i, j]+" ");
                }
                Console.WriteLine();
            }

        }

        public static bool Guvenlimi(int[,] Sudoku,int satir,int sutun,int rakam) //Boş olan kutucuğa yazacağımız rakam uygun mu değil mi 
        {
            for(int x = 0; x < N; x++)
            {
                if (Sudoku[x, sutun] == rakam)//Program dikeyde kontrol yapar
                {
                    return false;
                }
                
            }
            for(int y = 0; y < N; y++)
            {
                if (Sudoku[satir, y]==rakam) // Program yatayda kontrol yapar
                {
                    return false;
                }
            }
            //9X9 bir sudokuda toplamda 9 adet 3X3'lük kutucuk vardır 
            //Son olarak verilen rakam için ilgili kutucuğu kontrol etmek gerekir

            int Mini_Satir = satir - satir % 3;  //hangi Kutucukta bulunduğumuzun bilgisi 9 adet kutucuktan herhangi biri

            int Mini_Sutun = sutun - sutun % 3; 

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (Sudoku[Mini_Satir + i, Mini_Sutun + j] == rakam)
                    {
                        return false;
                    }
                }
            }

            return true; // ilgili kutucuğa yazılan rakam güvenlidir 

        }

        public static bool SudokuCozum(int[,] Sudoku,int satir,int sutun)
        {
            if (satir == N - 1 && sutun == N)
            {
                return true;
            }
            if (sutun == N)
            {
                satir += 1;
                sutun = 0;
            }
            if (Sudoku[satir, sutun] > 0) // ilgili kutucuk boş olana kadar devam et (0 kutucuğun boş olduğunu gösterir)
            {
                return SudokuCozum(Sudoku, satir, sutun + 1);
            }
           
            for(int rakam = 1; rakam <= 9; rakam++)//1'den 9'a kadar rakamları deneyeceğiz
            {
                if (Guvenlimi(Sudoku, satir, sutun, rakam))
                {
                    Sudoku[satir, sutun] = rakam;

                    if (SudokuCozum(Sudoku, satir, sutun + 1))
                    {
                        return true;
                    }

                    Sudoku[satir, sutun] = 0; //Backtracking işlemi
                    
                }

            }
            return false;

        }
        static void Main(string[] args)
        {
            //Program Girilen Sudokunun Çözümünü Ekrana Print Eder.
            //Geçerli bir sudoku girelim

            int[,] Sudoku =  { { 0, 0, 0, 0, 0, 0, 6, 1, 9 },
                               { 0, 2, 3, 0, 9, 0, 0, 0, 0 },
                               { 0, 0, 0, 1, 4, 0, 0, 2, 0 },
                               { 0, 0, 9, 0, 0, 0, 0, 0, 0 },
                               { 7, 0, 8, 0, 0, 3, 0, 0, 0 },
                               { 0, 0, 0, 0, 0, 5, 3, 4, 0 },
                               { 0, 0, 0, 0, 0, 0, 4, 6, 7 },
                               { 8, 3, 0, 0, 0, 0, 0, 0, 0 },
                               { 0, 0, 0, 6, 1, 2, 0, 0, 0 } };

            if (SudokuCozum(Sudoku, 0, 0))
            {
                EkranaBas(Sudoku);

            }
            else //Girilen Sudoku hatalıdır.
            {
                Console.Write("Geçerli bir çözüm yok"); 
            }
            Console.ReadLine();


        }
    }
}
