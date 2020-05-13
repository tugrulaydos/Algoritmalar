using System;

namespace ConsoleApp82
{
    class Program
    {   
        public static int Min(int a,int b,int c)
        {
            if (a > b)
            {
                if (b > c)
                {
                    return c;
                }
                else
                {
                    return b;
                }
            }
            else if (b > c)
            {
                if (c > a)
                {
                    return a;
                }
                else
                {
                    return c;

                }
            }
            else
            {
                return a;
            }
        }



        static void Main(string[] args)
        {
            //88.Ugly Sayısı Nasıl Bulunur
            int[] x = new int[88];
            x[0] = 1;  
            int[] carpan = new int[3];
            for (int i = 1; i < 88; i++)
            {
                x[i] = Min(x[carpan[0]] * 2, x[carpan[1]] * 3, x[carpan[2]] * 5);
                if (x[i] == x[carpan[0]] * 2) { carpan[0]++; }
                if (x[i] == x[carpan[1]] * 3) { carpan[1]++; }
                if (x[i] == x[carpan[2]] * 5) { carpan[2]++; }
            }
            Console.WriteLine(x[87]);
            Console.ReadLine();

            
          
           
        }
    }
}
