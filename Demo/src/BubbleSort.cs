using System;
using System.Collections.Generic;

namespace src
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            Sort(array, Comparer<T>.Default);
        }

        public static void Sort<T>(T[] array, IComparer<T> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (comparer.Compare(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                // 本轮没有发生交换，说明数组已有序，提前结束
                if (!swapped)
                {
                    break;
                }
            }
        }
    }
}
