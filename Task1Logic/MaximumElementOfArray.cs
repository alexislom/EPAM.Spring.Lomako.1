﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    /// <summary>
    /// Class for finding max element
    /// </summary>
    /// <remarks>Class which contains recursive algorithm for finding the maximum element in an arbitrary (unsorted) array</remarks>
    public static class MaximumElementOfArray
    {
        /// <summary>
        /// Search for the maximum element in arbitrary (unsorted) array
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="array">array reference</param>
        /// <param name="left">left border of array</param>
        /// <param name="right">right border of array</param>
        /// <returns>Maximum element of array</returns>
        public static T FindMaxElement<T>(T[] array,int left,int right) where T : IComparable<T>
        {
            if(array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (left < array.GetLowerBound(0) || right < array.GetLowerBound(0) || right < left)
            {
                throw new ArgumentOutOfRangeException(left < right ? "left border" : "right border");
            }
            if (left == right)
            {
                return array[left];
            }
            if(array[left].CompareTo(array[right]) >= 0)
            {
                return FindMaxElement<T>(array, left, --right);
            }
            else
            {
                return FindMaxElement<T>(array, ++left, right);
            }
        }
    }
}
