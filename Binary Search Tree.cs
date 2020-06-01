using System;

namespace ConsoleApp96
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search Tree
            //34 Elemanlı Bir Dizide Aranan Elemanı Bulunuz
            int [] x = new int[34]; //Arama Yapılacak Olan Dizi
            for(int i = 0; i < 34; i++)
            {
                x[i] = 3 * i; // 0 3 6 9 12 15 17 .........94 97 99 --> Sayılarımız

            }
            Console.Write("Aranan Sayıyı Giriniz:");
            int aranan = Int16.Parse(Console.ReadLine());
            int son = x.Length;  // son = 34
            int ilk = 0;            
            int indis = son / 2; //x[indis] = 51
            int sayac = 0;
            bool bulundumu = false;

            while (sayac < Math.Log(x.Length,2))//Hesaplama Karmaşıklığı Log(N)'dir 
            {
                if (x[indis] == aranan) { bulundumu = true; break; }
                if (x[indis] > aranan) { son = indis; }

                if(x[indis] < aranan) { ilk = indis; }

                indis = (son + ilk) / 2;

                sayac++;                
                
            }
            if (bulundumu)
            {
                Console.WriteLine("Aranan Eleman Dizide Mevcuttur");

            }
            else
            {
                Console.WriteLine("Aranan Eleman Dizide Bulunamadı");
            }
            Console.ReadLine();
           



            
        }
    }
}
