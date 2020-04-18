using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //A'dan Z'ye Kadar Harfleri Ve ASCII 
            //Degerlerinin Ekrana Yazdıran Program

            char karakter;
            int asciivalue;
            for(karakter = 'A'; karakter <= 'Z'; karakter++)
            {
                asciivalue = (int)karakter;
                Console.WriteLine("{0}:{1}", karakter,asciivalue);
                
            }
            Console.ReadLine();




        }
    }
}
