using System;

namespace ConsoleApp81
{
    class Program
    {
        static void Main(string[] args)
        {
            //a^3+b^3 == c^3+d^3 Eşitliğini Sağlayan a b c d Sayıları
            //Brute Force 
            //O(n^3)

            double d = 0;
            int adet = 0;
            for(int a = 0; a < 100; a++)
            {
                for(int b = 0; b < 100; b++)
                {
                    for(int c = 0; c < 100; c++)
                    {
                        d = a * a * a + b * b * b - c * c * c;
                        d = Math.Pow(d, 1.0 / 3);//KüpKök Alma İşlemi Bu Sayede Program Daha Hızlı Çalışır 
                        d = Math.Round(d);       //Sayıyı En Yakın Tamsayıya Eşitler
                        if (a != d && a != c)
                        {
                            if (d < 100)
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
            Console.WriteLine(adet);
            Console.ReadLine();
           
        }
    }
}
