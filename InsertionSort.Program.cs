using System;

namespace Insertion_sort
{
    class Program
    {
        static int[] performInsertionSort(int[] inputarray)
        {
            for (int i = 0; i < inputarray.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (inputarray[j - 1] > inputarray[j])
                    {
                        int temp = inputarray[j - 1];
                        inputarray[j - 1] = inputarray[j];
                        inputarray[j] = temp;

                    }
                    j--;
                }
            }
            return inputarray;
        }
    }
}
    