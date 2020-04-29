using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            // 64 Bitlik 2 Sayıyı Toplama
            uint B = 0x00000001;   uint A = 0x55555555; //BA 64 Bitlik Sayısı
            uint D = 0x00000001;   uint C = 0xaaaaaaab; //DC 64 Bitlik Sayısı
            uint X = 0x00000000;   uint Y = 0x00000000; //XY 64 Bitlik Sayısı

            uint Z = 0;//Değişken
            uint Tasma = 0;//Taşmayı Hesaba Katmalıyız
            uint elde = 0;

            //A ve C yi Sağa Shift Edip Toplarız Eğer 32.Bit 1 ise Taşma Vardır.
            
        
            if (A % 2 == 1 && C % 2 == 1) // A ve C Tek ise Elde 1 Olmalıdır
            {
                elde = 1;
            }

            Z = (A >> 1) + (C >> 1) + elde;

            if ((Z & 0x80000000) != 0) //32.Bit 1'dir ve Taşma Vardır
            {
                Tasma = 1;
            }

            Y = A + C;
            X = B + D + Tasma;
            

            
        }
    }
}
