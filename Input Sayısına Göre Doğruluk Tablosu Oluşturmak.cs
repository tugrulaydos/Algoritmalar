using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Sayısını Giriniz:");
            int Input = Int16.Parse(Console.ReadLine());
            string s = "";
            for(int i = 0; i < Math.Pow(2,Input); i++)
            {
                int mask = 1;

                for(int j = 0; j < Input ; j++)
                {

                    if ((mask & i)!=0)
                    {
                        s = "1 " + s;

                    }
                    else
                    {
                        s = "0 " + s;
                    }
                    mask = mask << 1;
                }
                Console.WriteLine(s);
                s = "";
            }
            Console.ReadLine();
          
        }
    }
}
