using System;

namespace ConsoleApp5
{
    class Program
    {
        public static void Main(int[] a)
        { 
            sort(a, 0, a.Length - 1);
        }

        static void sort(int[] a, int start, int end)
            {
                if (start >= end)
                {
                    return;
                }

                int num = a[start];

                int i = start, j = end;

                while (i < j)
                {
                    while (i < j && a[j] > num)
                    {
                        j--;
                    }

                    a[i] = a[j];

                    while (i < j && a[i] < num)
                    {
                        i++;
                    }

                    a[j] = a[i];
                }

                a[i] = num;
                sort(a, start, i - 1);
                sort(a, i + 1, end);
            }
        }

       
    }

