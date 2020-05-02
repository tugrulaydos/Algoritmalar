using System;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aranan İfadeyi Bulan Program
            string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string q = "JKLMNO";
            int state = 0;
            bool bulundumu = false;
            for(int i = 0; i < s.Length; i++)
            {                
                if (s[i] == q[state])
                {
                    state++;
                    if (state == q.Length) { bulundumu = true; i = s.Length; } 
                    
                }
                else
                {
                    state = 0;
                }
            }

            if (bulundumu) { Console.WriteLine("Bulundu"); }
            else
            {
                Console.WriteLine("Bulunamadı");
            }
            Console.ReadLine();
        }
    }
}
