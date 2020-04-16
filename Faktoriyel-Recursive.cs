using System;

namespace ConsoleApp10
{
    class Program
    {
        //Recursive Faktoriyel Hesabı Yapan Kod
        
        public static int f(int a)
        {             
            if (a == 1)
            {
                return a;
             }
            
            return a * f(a - 1); 
        }
        static void Main(string[] args)
        {
            Console.Write("Deger:");
            int x = Int16.Parse(Console.ReadLine());
            Console.WriteLine(f(x));
            Console.ReadLine();            
        }
        
    }
}
