using System;

namespace ConsoleApp113
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

            if (a > c)
            {
                return c;
            }

            return a;
        }
        public static int isUgly(int[] x,int[] carpan,int indis)
        {
            if (indis == 88)
            {
                return x[87];
            }
            else
            {
                x[indis] = Min(x[carpan[0]] * 2, x[carpan[1]] * 3, x[carpan[2]] * 5);

                if(x[indis] == x[carpan[0]] * 2) { carpan[0]++; }
                if (x[indis] == x[carpan[1]] * 3) { carpan[1]++; }
                if (x[indis] == x[carpan[2]] * 5) { carpan[2]++; }

                return isUgly(x, carpan, ++indis);

            }

        }
        static void Main(string[] args)
        {
            //87.Ugly Sayısını Recursive Metot Kullanarak Bulunuz. 

            int[] x = new int[100];
            int[] carpan = new int[3];
            x[0] = 1;
            int indis = 1;
            Console.WriteLine(isUgly(x, carpan, indis));


           
        }
    }
}
