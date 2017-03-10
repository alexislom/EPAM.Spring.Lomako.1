using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 6 };
            int[] arrr = { 4, 4, 3, 2, 677, 8 };
            int? result = IndexOfLeftRightSum.IndexOfEqualsSum(arr);
            if (result.HasValue)
            {
                Console.WriteLine(result);
            }
        }
    }
}
