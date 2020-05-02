using System;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aranılan İfadeyi Verilen String içerisinde Bulan Program
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string q = "KLMNOP";
            int h = 0;
            bool bulundumu = false;
            for(int i = 0; i < s.Length; i++)
            {
                h = 0;
                while (s[i + h] == q[h])
                {
                    h++;

                    if (h == q.Length) { bulundumu = true; break; }                  

                }
            }
            if (bulundumu) { Console.WriteLine("Aranan İfade Bulundu"); }

            else { Console.WriteLine("Bulunamadı"); }

            Console.ReadLine();
            
        }
    }
}
