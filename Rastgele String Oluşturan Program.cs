using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 Karakterli Rastgele String Oluşturan Program

            int[] rakam = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            char[] harf = new char[26] {'A','B','C','D','E','F','G','H','I','J',
            'K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

            Random rnd = new Random();

            int rastgele;

            for(int i = 0; i < 5; i++)
            {
                rastgele = rnd.Next(1, 3);
                if (rastgele == 1)
                {
                    Console.Write(rakam[rnd.Next(0, 10)]);
                }
                if(rastgele == 2)
                {
                    Console.Write(harf[rnd.Next(0,26)]);
                }
                
            }
            Console.ReadLine();      
                                 
        }
    }
}
