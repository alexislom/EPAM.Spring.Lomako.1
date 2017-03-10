using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Logic
{
    /// <summary>
    /// Class which contains method of merge sort
    /// </summary>
    public static class Algorithm
    {
        /// <summary>
        /// Method of merge sort of array
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="array">reference to array</param>
        public static void MergeSort<T>(T[] array) where T : IComparable<T>
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            MergeSort(array, 0, array.Length);

        }
        /// <summary>
        /// Intermediate sorting method
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="array">reference to array</param>
        /// <param name="low">low border of intermediate array</param>
        /// <param name="high">high border of intermediate array</param>
        public static void MergeSort<T>(T[] array, int low, int high) where T : IComparable<T>
        {
            int N = high - low;
            if (N <= 1)
                return;

            int middle = low + N / 2;

            MergeSort(array, low, middle);
            MergeSort(array, middle, high);

            T[] temp = new T[N];
            int i = low;
            int j = middle;

            for (int index = 0; index < N; index++)
            {
                if (i == middle)
                {
                    temp[index] = array[j++];
                }
                else if (j == high)
                {
                    temp[index] = array[i++];
                }
                else if (array[j].CompareTo(array[i]) < 0)
                {
                    temp[index] = array[j++];
                }
                else temp[index] = array[i++];
            }

            for (int index = 0; index < N; index++)
            {
                array[low + index] = temp[index];
            }
        }
    }
}
