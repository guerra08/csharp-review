using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s = new Sorting();
            int[] myArray = {1,2,3,4,5,8,7};
            s.BubbleSort(myArray);
            PrintArray(myArray);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
