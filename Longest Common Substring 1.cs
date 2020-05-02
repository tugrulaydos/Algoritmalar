using System;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            //String  içerisinde Aranan İfadeyi  Bulan Program
            //Longest Common Substring 
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string q = "QRSTUV";
            bool bulundumu = false;
            for(int i = 0; i <= s.Length - q.Length; i++)
            {
                if(q[0] == s[i])
                {
                    
                    for(int j = 1; j < q.Length; j++)
                    {
                        if (s[i + j] != q[j]) { bulundumu = false; j = q.Length - 1; }

                        else { bulundumu = true; }
                        
                    }

                }        
                

            }
            if (bulundumu) { Console.WriteLine("Aranan İfade Bulundu"); }

            else { Console.WriteLine("Bulunamadı"); }

            Console.ReadLine();
            
        }
    }
}
