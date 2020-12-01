using System;

namespace Kart_Dagitma
{
    class Program
    {
        public static void Desteyi_Kar(int[,] Deste)
        {
            Random rnd = new Random();
            int kart, satir, sutun;

            for (kart = 1; kart <= 52; kart++)
            {
                do
                {
                    satir = rnd.Next(0, 4);
                    sutun = rnd.Next(0, 13);
                } while (Deste[satir, sutun] != 0);

                Deste[satir, sutun] = kart;

            }
            
        }

        public static void Kartlari_Dagit(int[,] Deste,string[] Takim,string[] Taraf)
        {
            int kart, satir, sutun;

            for (kart = 1; kart <= 52; kart++)
            {
                for (satir = 0; satir < 4; satir++)
                {
                    for(sutun = 0; sutun<13; sutun++)
                    {
                        if (Deste[satir, sutun] == kart)
                        {
                            Console.Write("{0}||{1}{2}", Takim[satir], Taraf[sutun],
                                                         kart % 2 == 0 ? '\n' : '\t');
                        }
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            int[,] deste = new int[4, 13]; 

            string[] takim = {"Karo","Maca","Sinek","Kupa"};

            string[] taraf = { "As", "iki", "Uc", "Dort", "Bes", "Alti", "Yedi", "Sekiz", "Dokuz", "On", "Vale", "Kiz", "Papaz" };

            Desteyi_Kar(deste);

            Kartlari_Dagit(deste, takim, taraf);
            
            Console.ReadLine();
           
        }
    }
}
