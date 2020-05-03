using System;
using System.Text;

namespace ConsoleApp70
{
    class Program
    {			
		static void Main(string[] args)
        {
            //Verilen String ifade Polindromik midir?
            //Polindromik string --> Sağdan ve Soldan Bakıldığında Aynı Stringe Eşittir

            string s = "12345678987654321";
            string reverse = "";
            for(int i = 0; i < s.Length; i++)
            {
                reverse = s[i].ToString() + reverse;
            }
            if (s == reverse)
            {
                Console.WriteLine("Polindromiktir");

            }
            else
            {
                Console.WriteLine("Polindromik Değildir");
            }
            Console.ReadLine();
           

		
           
        }
    }
}
