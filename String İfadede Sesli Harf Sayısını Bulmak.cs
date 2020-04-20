using System;
namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Girilen Metindeki Sesli Harf Sayasını Bulan Program
            Console.Write("Bir Metin Giriniz:");
            string metin = Console.ReadLine();
            char[] sesli = new char[] { 'a', 'e', 'u', 'ü', 'i', 'ı', 'o', 'ö' };
            metin = metin.ToLower();  //Case-Sensitivity Engellemek için Metindeki Tüm Harfleri Küçük Harf Yapar 
            int seslisayi = 0;
            for(int i = 0; i < metin.Length; i++) 
            {
                for(int j = 0; j < sesli.Length; j++)
                {
                    if (metin[i] == sesli[j])
                    {
                        seslisayi++;
                        break;

                    }
                }
            }
            Console.WriteLine("Sesli Harf Sayısı:{0}",seslisayi);
            Console.ReadLine();




            
        }
    }
}
