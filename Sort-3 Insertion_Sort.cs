using System;

namespace Sort_3_Insertion_Sort
{
    class Program
    {
        public static void Insertion_Sort(int [] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i]; //Geçiçi değer
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j+1] = arr[j];

                    j = j - 1;
                }

                arr[j+1] = temp;

            }

        }
        static void Main(string[] args)
        {
            int[] array = { 1,4,15,12,3,2,5,6,11,7,13,8,9,14,10};

            Console.WriteLine("Sıralanmadan Önce:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Insertion_Sort(array);
            Console.WriteLine("\nSıralandıktan Sonra:");

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

            
            
        }
    }
}
