﻿using System;

namespace ConsoleApp8
{
    class Program
    {
        public static int toplam(int i)
        {
            if (i > 100)
            {
                return 0;
            }

            return i + toplam(i + 1);

        }
        static void Main(string[] args)
        {
            Console.Write(toplam(0));
            Console.ReadLine();
            
        }
    }
}
