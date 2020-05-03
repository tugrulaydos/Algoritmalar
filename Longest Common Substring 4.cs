using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            //Longest Common Substring 
            //Aranan İfadenin String Metinde Olup Olmadığını Bulan Program
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string q = "QRSTUV";
            int max = 0;

            int[,] x = new int[s.Length, q.Length];
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < q.Length; j++)
                {
                    if (s[i] != q[j])
                    {
                        x[i, j] = 0;
                    }
                    else
                    {
                        if (i == 0 || j == 0)
                        {
                            x[i, j] = 1;
                        }
                        else
                        {
                            x[i, j] = x[i - 1, j - 1] + 1;
                        }
                        max = Math.Max(x[i, j], max);

                    }
                    
                }
            }
            if (max == q.Length)
            {
                Console.WriteLine("Aranan İfade Bulundu");
            }
            else
            {
                Console.WriteLine("Bulunamadı");
            }
            Console.ReadLine();

            
        }
    }
}
