using System;

namespace Sort_2_Bubble_Sort
{
    class Program
    {
        public static void BubbleSort(int[] array)
        {
            int temp = 0;
            for(int i = 0; i < array.Length - 1; i++) 
            {
                for(int j = 1; j < array.Length - i; j++)
                {
                    if (array[j-1] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;

                    }

                }

            }

        }
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 4, 2, 7, 8, 3, 1, 6, 9};

            BubbleSort(array);

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
                        
            
        }
    }
}
