using System;

namespace ConsoleApp108
{
    class Program
    {
        public static int hf(int data) 
        {
            int toplam = 0;
            while (data > 0)
            {
                toplam += data % 10;
                data = data / 10;
            }
            return toplam;
        }
        public static bool search (int aranacak,int [] dizi)  // Arama İşlemi
        {
            if(aranacak == dizi[hf(aranacak)])
            {
                return true; //Çakışma Yok Aranan Dizide Mevcut
            }
            if (dizi[hf(aranacak)] == 0)
            {
                return false;//Çakışma Yok Aranan da Yok
            }
            int indis = hf(aranacak);
            while (dizi[indis] != 0)
            {
                if (dizi[indis] == aranacak)
                {
                    return true; //Çakışma Var Aranan Eleman da Var
                }
                indis++;
            }
            return false; //Çalışma Var Aranan Eleman Yok
        }     
        
        static void Main(string[] args)
        {
            //Bir Eleman Aranan Bir Dizide Mevcut mu Değil mi?

            int indis = 0;
            int[] hash = new int[100];
            int[] eklenecekler = { 9, 3, 21, 3, 55, 6, 33, 6, 4, 5, 21};

            for(int i = 0; i < eklenecekler.Length; i++)
            {
                if (hash[hf(eklenecekler[i])] == 0)
                {
                    hash[hf(eklenecekler[i])] = eklenecekler[i];

                }
                else
                {
                    indis = hf(eklenecekler[i]);
                    while (hash[indis] != 0)
                    {
                        if (hash[indis] == eklenecekler[i])
                        {
                            break;
                        }
                        indis++;
                    }
                    hash[indis] = eklenecekler[i];                   
                }

            }
            
            int[] elemanlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};//Eklenecekler Dizisinde Bu Elemanlar Mevcut mu? 
            
            //Arama İşlemi 
            
            for(int i = 0; i < elemanlar.Length; i++)
            {
                if (search(elemanlar[i], hash))
                {
                    Console.WriteLine("Bulundu");
                }
                else
                {
                    Console.WriteLine("Bulunamadı");
                }
            }
            Console.ReadLine();
           
            


           

            
        }
    }
}
