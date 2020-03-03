using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {9,2,8,4,5};
            Sorting.SelectionSort(myArray);
            PrintArray(myArray);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
