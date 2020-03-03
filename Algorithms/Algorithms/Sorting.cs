using System;

namespace Algorithms
{
    class Sorting
    {
        public static void BubbleSort(int []array)
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

        public static void InsertionSort(int[] array)
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

        public static void MergeSort(int[] array)
        {
            if(array.Length <= 1)
            {
                return;
            }
            _MergeSort(array, 0, array.Length - 1);
        }

        private static void _MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                _MergeSort(arr, l, m);
                _MergeSort(arr, m + 1, r);

                _Merge(arr, l, m, r);
            }
        }

        private static void _Merge(int[] arr, int start, int mid, int end)
        {
            int start2 = mid + 1;

            if (arr[mid] <= arr[start2])
            {
                return;
            }

            while (start <= mid && start2 <= end)
            {

                if (arr[start] <= arr[start2])
                {
                    start++;
                }
                else
                {
                    int value = arr[start2];
                    int index = start2;

                    while (index != start)
                    {
                        arr[index] = arr[index - 1];
                        index--;
                    }
                    arr[start] = value;

                    start++;
                    mid++;
                    start2++;
                }
            }
        }

        public static void SelectionSort(int []arr)
        {
            if (arr.Length <= 1) return;
            int size = arr.Length;

            int min;
            int j, k;

            for (int i = 0; i < size; i++)
            {
                min = arr[i];
                k = i;

                if (i == size - 1) j = i;
                else j = i + 1;

                while (j < size)
                {
                    if(arr[j] < min)
                    {
                        min = arr[j];
                        k = j;
                    }
                    j++;
                }

                int aux = arr[i];
                arr[i] = arr[k];
                arr[k] = aux;
            }
        }

    }
}
