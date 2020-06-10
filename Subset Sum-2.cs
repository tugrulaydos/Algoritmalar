using System;

namespace ConsoleApp111
{
    class Program
    {
        public static bool isSubsetSum(int[] set,int n,int sum)
        {
            if (sum == 0) { return true; }
            if (sum != 0 && n == 0) { return false; }
            if (set[n - 1] > sum) { return isSubsetSum(set, n - 1, sum); }

            return isSubsetSum(set, n - 1, sum) || isSubsetSum(set, n - 1, sum - set[n - 1]);
        }        
        static void Main(string[] args)
        {
            //Verilen Kümede Altküme Elemanları Toplamı 465 Olan Altküme Mevcut mu?

            int[] set = new int[30];
            for(int i = 0; i < 30; i++)
            {
                set[i] = i + 1; //Verilen Kümemiz 
            }
            int sum = 465;
            int n = set.Length;

            if (isSubsetSum(set, n, sum))
            {
                Console.WriteLine("Verilen Toplamda Alt Küme Mevcuttur");
            }
            if (!isSubsetSum(set, n, sum))
            {
                Console.WriteLine("Verilen Toplamda Alt Küme Mevcut Değildir");
            }
            Console.ReadLine();



           
            
        }
    }
}
