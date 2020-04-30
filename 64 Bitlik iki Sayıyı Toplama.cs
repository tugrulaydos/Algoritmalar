using System;

namespace ConsoleApp62
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //64 Bitlik 2 Sayıyı Toplama 
            uint A = 0x00000001; uint B = 0x55555555; //64 Bitlik AB Sayısı.
            uint C = 0x00000001; uint D = 0xaaaaaaab; //64 Bitlik DC Sayısı.
            uint X = 0x00000000; uint Y = 0x00000000; //64 Bitlik XY Sayısı.

            int temp = 0; // Geçici Değer 
            uint elde = 0;
            // B + D = temp --> temp-B = D 

            temp = (int)(B + D);//Negatif Değerleri Hesaba Katmak için Type Casting yapmalıyız

            if ((temp - B) != D) //Eşit Değilse Taşma Vardır Ve Elde Değeri 1 Olmalıdır.  
            {
                elde = 1;
            }
            Y = B + D;
            X = A + C + elde;
            Console.WriteLine(X);
            Console.WriteLine(Y);







        }
    }
}
