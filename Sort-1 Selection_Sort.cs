using System;

namespace Sort_1_SelectionSort
{
    class Program
    {
        public static void SelectionSort(int[]array)
        {
            int indis=0;

            int temp=0;

            for(int i = 0; i < array.Length; i++)
            {
                indis = i;  
                for(int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[indis])
                    {
                        indis = j;

                    }
                }
                temp = array[i];

                array[i] = array[indis];

                array[indis] = temp;

            }


        }
        static void Main(string[] args)
        {
            //Her adımda en küçük eleman seçilip dizinin baş tarafına gönderilir

            int[] array = { 5, 7, 2, 1, 9, 10, 8, 3, 6, 4};          


            SelectionSort(array);

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();


            
        }
    }
}
