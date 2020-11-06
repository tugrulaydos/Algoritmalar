using System;

namespace BackTracking_1_Rat_in_Maze
{
    class Program
    {
        public static int N = 5; // Labirentin en ve boyu  
        public static void PrintSolution(int[,]yol) //Sonucu Ekrana Bas
        {
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(" "+yol[i,j]);

                }
                Console.WriteLine();
            }
        }

        public static bool Guvenlimi(int x,int y,int[,] labirent)//fare'nin labirentten dışarı çıkmamasını ve gidilecek karenin uygun olup olmadığını kontrol eder. 
        {
            if (x >= 0 && x < N && y >= 0 && y < N && labirent[x, y] == 1)
            {
                return true;
            }

            return false;

        }

        public static bool Cozum(int [,] labirent,int[,]yol,int x,int y)//(labirent, yol, farenin bulundugu satir, farenin bulundugu sutun)
        {
            if (yol[N-1, N-1] == 1) //Eger fare çıkış noktasına ulastıysa 
            {
                return true;
            }

            if (Guvenlimi(x, y, labirent))
            {
                yol[x, y] = 1;

                if (Cozum(labirent, yol, x + 1, y))
                {
                    return true;
                }
                if (Cozum(labirent, yol, x, y + 1))
                {
                    return true;
                }

                yol[x, y] = 0; //Backtracking işlemi

                //Eğer 2 if döngüsüne de girilmesse en son noktaya geri dönülür (doğru çözüme ulaştıracağı varsayılan noktaya) 


            }
            return false; //çözüm yoktur 

        }
        static void Main(string[] args)
        {
            //Bir fare N*N'lik bir labirentte yalnızca aşağı ve sağa hareket ederek çıkışa nasıl ulaşır
            //1'ler yol orada olduğunu 0'lar farenin oradan geçemeyeceğini gösterir.

            int[,] labirent ={{1, 1, 0, 0, 1},
                              {1, 1, 1, 0, 1},
                              {1, 0, 1, 1, 1},
                              {1, 0, 0, 0, 1},
                              {0, 1, 1, 1, 1}};

            //sol üst başlangıç noktası sağ üst çıkış noktasıdır
            //Program yalnızca bir çözümü ekrana print eder birden fazla çözüm olabilir.

            int[,] yol ={{0,0,0,0,0},
                         {0,0,0,0,0},
                         {0,0,0,0,0},
                         {0,0,0,0,0},
                         {0,0,0,0,0}};


            if (Cozum(labirent, yol, 0, 0))
            {
                PrintSolution(yol);
            }
            else
            {
                Console.Write("Çözüm Yoktur");
            }

            Console.ReadLine();

            
            
        }
    }
}
