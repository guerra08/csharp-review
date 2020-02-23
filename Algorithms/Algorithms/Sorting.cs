using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Sorting
    {
        public void BubbleSort(int []array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            int n = array.Length;
            int count = 0;
            Boolean swap = false;

            while (count < n)
            {
                if (count == n - 1 && swap == false)
                {
                    break;
                }

                if (count == n - 1 && swap == true)
                {
                    swap = false;
                    count = 0;
                }

                if (array[count] > array[count + 1]) {
                    int aux = array[count + 1];
                    array[count + 1] = array[count];
                    array[count] = aux;
                    swap = true;
                }

                count++;
            }
        }

        public void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

    }
}
