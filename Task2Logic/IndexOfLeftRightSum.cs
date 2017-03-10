using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public static class IndexOfLeftRightSum
    {
        public static int? IndexOfEqualsSum(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length < 3)
            {
                return null;
            }
            int leftSum = array[0];
            int rightSum = 0;

            for (int i = 2; i < array.Length; i++)
            {
                rightSum += array[i];
            }
                
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (leftSum == rightSum)
                {
                    return i;
                }
                leftSum += array[i];
                rightSum -= array[i + 1];
            }

            return null;
        }

    }
}
