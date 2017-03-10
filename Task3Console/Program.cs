using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Logic;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = random.Next(1, 101);
            }
            
            Console.WriteLine("Array before merge sort:");
            foreach (var x in arr)
            {
                Console.Write(x + " ");
            }

            Algorithm.MergeSort<int>(arr);
            Console.WriteLine("\nArray after merge sort:");
            foreach (var x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}
