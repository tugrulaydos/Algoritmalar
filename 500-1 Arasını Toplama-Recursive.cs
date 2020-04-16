using System;

namespace ConsoleApp9
{
    class Program
    {
        //500 ve 1 Arasındaki Sayıları Toplayan Program
        static int toplam=0; // Global
        public static void topla(int i)
        {
            if (i == 0)
            {
                return; //Metottan Çık
            }

            toplam = i + toplam; 
            topla(i - 1);  // Burada Özyineleme Yapıyor 

        }
        static void Main(string[] args)
        {
            topla(500);  // 500'den Geriye Doğru Toplama İşlemi
            Console.WriteLine(toplam);
            Console.ReadLine();


            
        }
    }
}
