using System;

namespace BackTracking_4
{
    class Program
    {
        public static void EkranaYaz(int[,] tahta)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (tahta[i, j] < 10)
                    {
                        Console.Write(" "); //Matriste Kaymayı engelledik
                    }
                    Console.Write(tahta[i,j]+" ");
                }

                Console.WriteLine();
            }

        }
        public static bool Guvenlimi(int x,int y,int [,] tahta) //atın tahtadan dışarı çıkamamasını ve aynı yere 2 defa gelmemesini kontrol eder 
        {
            if (x >= 0 && x < 8 & y >= 0 && y < 8 && tahta[x, y] == 0)
            {
                return true;
            }
            return false;

        }


        public static bool HareketEttir(int x,int y,int Hareket,int [] yatay,int[] dikey,int[,] tahta)
        {
            int Sonraki_D; //Dikey
            int Sonraki_Y; //Yatay

            if (Hareket == 65) //at tüm kareleri gezmiş demektir 
            {
                return true;
            }

            for(int i = 0; i < 8; i++) //atın 8 farklı hareketi
            {
                Sonraki_D = x + dikey[i]; 

                Sonraki_Y = y + yatay[i];

                if (Guvenlimi(Sonraki_D, Sonraki_Y, tahta))
                {                

                    tahta[Sonraki_D, Sonraki_Y] = Hareket;

                    if (HareketEttir(Sonraki_D, Sonraki_Y, Hareket + 1, yatay, dikey, tahta))
                    {
                        return true;
                    }

                    tahta[Sonraki_D, Sonraki_Y] = 0; //BackTracking işlemi

                }
                
            }
            return false;

        }



        static void Main(string[] args)
        {
            //Bir at satranç tahtasında tüm karelere bir defa gelmek koşuluyla satranç tahtasındaki tüm kareleri gezebilir mi?

            int[,] tahta = new int[8, 8]; //Satranç Tahtası

            //At L hareket eder ve tahtada toplamda 8 farklı hareket yapabilir(2 sağ 1 aşağı ve 2 sağ 1 yukarı ve 2 yukarı 1 sağ ve........)

            int[] yatay = { 2, 1, -1, -2, -2, -1, 1, 2 }; //Atın Yataydaki hareketi

            int[] dikey = { -1, -2, -2, -1, 1, 2, 2, 1 }; //Atın dikeydeki hareketi

            //sola ve yukarı olan hamleler negatif olarak belirtildi

            int x = 7; //atın tahtadki satir konumu

            int y = 7; //atın tahtadaki sutun konumu

            tahta[x, y] = 1; //Başlangıç Konumu 

            if (HareketEttir(x, y, 2, yatay, dikey, tahta))
            {
                EkranaYaz(tahta);

            }
            else
            {
                Console.Write("Çözüm Mevcut Değil");
            }

            Console.ReadLine();

            //Atı ortadan bir yerden başlatmak programın sonuç verme oranını azaltır bu erilebilirliği
            //yüksek olan karelere önceden gidilmesi demektir.Örneğin 0,0 konumuna yalnızca 2 kareden erişim vardır
            //eğer ortadaki karlere(erişilebilirliği yüksek olan kareler) başta gidilirse 0,0 konumuna gitme şansımız azalacaktır
            //Bundan dolayı başarı şansını artırmak için programı köşedeki karelerin birinden başlatmayı uygun gördüm
            
            //Atı orta karelerden başlatırsak program uzun süre çıktı vermeyebilir ya da çözüm mevcut olmayabilir
            
            

           
           
            



        }
    }
}
