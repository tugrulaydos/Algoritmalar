using System;

namespace ConsoleApp115
{
    class Program
    {
        public static bool isUgly(int data)
        {
            while (data % 2 == 0)
            {
                data = data / 2;
            }
            while (data % 3 == 0)
            {
                data = data / 3;
            }
            while (data % 5 == 0)
            {
                data = data / 5;
            }
            if (data == 1)
            {
                return true;
            }
            return false;

        }
        public static int Ugly87(int sayac,int adet,int Ugly)
        {
                        
            if (isUgly(sayac))
            {
                Ugly = sayac;
                return Ugly87(++sayac, ++adet,Ugly);

            }
            if (adet == 34)
            {
                return Ugly;
            }
            return Ugly87(++sayac, adet,Ugly);

        }
        static void Main(string[] args)
        {
            //87.Ugly Sayısını Recursive Olarak Bulan Program
            int sayac = 2;
            int adet = 0;
            int Ugly = 0;
            Console.WriteLine(Ugly87(sayac,adet,Ugly));
            Console.ReadLine();
                             


           
        }
    }
}
