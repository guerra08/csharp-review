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

    }
}
