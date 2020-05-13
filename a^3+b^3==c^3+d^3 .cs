using System;

namespace ConsoleApp80
{
    class Program
    {
        static void Main(string[] args)
        {
            //a^3+b^3==c^3+d^3 Eşitliğini Sağlayan  a b c d Sayılarını Bulunuz
            //Brute Force Algoritması
            int adet = 0;
            for(int a = 0; a < 100; a++)
            {
                for(int b = 0; b < 100; b++)
                {
                    for(int c = 0; c < 100; c++)
                    {
                        for(int d = 0; d < 100; d++)
                        {
                            if (a != d && a != c)
                            {
                                if (a * a * a + b * b * b == c * c * c + d * d * d)
                                {
                                    Console.WriteLine("{0} {1} == {2} {3}", a, b, c, d);
                                    adet++;
                                }
                            }

                        }

                    }
                }
            }
            Console.WriteLine("Sağlayan {0} Deger Vardır", adet);
            Console.ReadLine();
        }
    }
}
