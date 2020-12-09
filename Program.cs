using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 9, 7, 6, 15, 17, 5, 10, 11 };

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
