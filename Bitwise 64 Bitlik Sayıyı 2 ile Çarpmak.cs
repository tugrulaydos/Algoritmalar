using System;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            // 64 Bitlik Bir Sayıyı 2 ile Çarpma

            uint a = 0x8000000f; //32 Bit 
            uint b = 0x00000001; //32 Bit

            //64 Bitlik Sayımız ba'dır

            uint elde = 0;
            if ((a & 0x80000000) != 0) // En Soldaki Bit 1'dir
            {
                elde = 1; //Eldeyi de Hesaba Katmalıyız Yoksa 1 Bit Yok Etmiş Oluruz.(Over Flow) 
            }
            //Sayıları 2 ile Çarpıyoruz(Sola Shift)
            a = a << 1; 
            b = (b << 1) + elde; 


            //2.Çözüm
            //b = (b << 1) + (a >> 31); 
            //a = a << 1;
            
          
           
        }
    }
}
