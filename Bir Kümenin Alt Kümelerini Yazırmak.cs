using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Herhangi Bir Kümenin Alt Kümelerini Ekrana Yazan Program

            string s = "ABCD"; 
            for(int i = 0; i < Math.Pow(2, s.Length);i++)
            {
                int mask = 1;
                for(int j = 0 ; j < s.Length ; j++)
                {
                    if ((mask & i) != 0)
                    {
                        Console.Write(s[j]);
                    }
                   
                    mask = mask << 1;
                                        
                }
                Console.WriteLine();

            }
            Console.ReadLine();
            
        }
    }
}
