using System;

namespace ConsoleApp36
{
    class Program
    {
        public static int bul(int[] x, int a)
        {
            
            if (a == 10)
            {
                return 0;
            }
            if ((x[a] & 1) == 0)
            {
                return 1 + bul(x, a + 1);
            }
            else
            {
                return 0 + bul(x, a + 1);
            }


        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] dizi = new int[10];
            for(int i = 0; i < 10; i++)
            {
                dizi[i] = rnd.Next(1, 10);
                Console.Write(dizi[i]+"  ");
            }
            Console.Write("\nÇift Sayı Adedi:{0}",bul(dizi, 0));
            Console.ReadLine();




        }
    }
}
