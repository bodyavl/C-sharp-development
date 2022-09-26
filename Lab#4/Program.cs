using System;

namespace Lab4_university
{
    internal class Program
    {
        static void showArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int n = 1;
            string? strN;
            bool nIsValid = false;
            var rand = new Random();

            do
            {
                Console.WriteLine("Enter array length");
                strN = Console.ReadLine();
                nIsValid = int.TryParse(strN, out n) && n > 0;
                if (nIsValid) break;
                Console.WriteLine("Enter valid array length");
            } while (!nIsValid);

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(101);
            }
            Console.WriteLine();
            Console.WriteLine("Original array:");
            showArray(array);

            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            swap(ref array[maxIndex], ref array[minIndex]);
            Console.WriteLine("Array after swapping max and min elements:");
            showArray(array);
        }
    }
}