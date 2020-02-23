using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s = new Sorting();
            int[] myArray = {1,2,3,4,5,8,7};
            int[] other = { 2, 1, 5, 6, 9, 3 };
            s.BubbleSort(myArray);
            //PrintArray(myArray);
            s.InsertionSort(other);
            PrintArray(other);
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
