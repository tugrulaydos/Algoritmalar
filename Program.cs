using System;

namespace ConsoleApp9
{
    class Program
    {
        static int toplam=0;
        public static void topla(int i)
        {
            if (i == 0)
            {
                return; //Metottan Çık
            }

            toplam = i + toplam;
            topla(i - 1);

        }
        static void Main(string[] args)
        {
            topla(100);  // 100'den Geriye Doğru Toplama İşlemi
            Console.WriteLine(toplam);
            Console.ReadLine();


            
        }
    }
}
