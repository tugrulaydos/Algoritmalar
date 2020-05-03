using System;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polindromik String
            string s = "alkazıkçakkarayakayarakkaçkızakla";
            int left = 0;
            int right = s.Length-1;
            bool polindromik = false;
            while (s[left] == s[right])
            {
                left++;
                right--;                
                if (left > right)
                {
                    polindromik = true;
                    break;
                }
            }
            if (polindromik)
            {
                Console.Write("Polindromiktir");
            }
            else
            {
                Console.Write("String Polindromik Değildir");
            }
            Console.ReadLine();
            
        }
    }
}
