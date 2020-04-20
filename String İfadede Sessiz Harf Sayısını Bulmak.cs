using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Girilen Metindeki Sesli ve Sessiz Harf Sayasını Bulan Program
            Console.Write("Bir Metin Giriniz:");
            string metin = Console.ReadLine();
            char[] sesli = new char[] { 'a', 'e', 'u', 'ü', 'i', 'ı', 'o', 'ö' };
            metin = metin.ToLower();  //Case-Sensitivity Engellemek için Metindeki Tüm Harfleri Küçük Harf Yapar 
            int seslisayi = 0;
            int sessizsayi = 0;
            bool evet = false;  //if Bloğunun Çalışıp Çalışmadığnı Kontrol Eder 
            for (int i = 0; i < metin.Length; i++)
            {
                for (int j = 0; j < sesli.Length; j++)
                {
                    if (metin[i] == sesli[j])
                    {
                        evet = true;
                        seslisayi++;
                        break;

                    }
                }
                if (!evet)
                {
                    sessizsayi++;
                }
                evet = false;
            }
            Console.WriteLine("Sesli Harf Sayısı:{0}", seslisayi);
            Console.WriteLine("Sessiz Harf Sayısı:{0}", sessizsayi);
            Console.ReadLine();
        }
    }
}
