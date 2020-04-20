using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir String'i 4 Parçaya Bölme işlemi
            string s = "abcdabcdabcdabcdabcdabcd";
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();


        }
    }
}
