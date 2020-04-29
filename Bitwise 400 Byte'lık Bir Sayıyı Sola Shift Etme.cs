using System;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            //400 Byte'lık Bir Sayıyı Sola Shift işlemi

            uint[] x = new uint[100];//Dizi'nin Elemanlarını 400 Byte'lık Sayı Gibi Düşünebiliriz.
            uint elde = 0;
            uint oncekielde = 0;
            for(int i = 0; i < 100; i++)
            {
                if ((x[i] & 0x80000000) != 0) { elde = 1; }

                else { elde = 0; }

                x[i] = x[i] << 1;

                x[i] = x[i] + oncekielde;

                oncekielde = elde;
            }
            
        }
    }
}
