using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 20, 3, 0, 50, 50, 3, 23, 5 };
            int result = MaximumElementOfArray.FindMaxElement<int>(arr, 0, arr.Length - 1);
            Console.WriteLine(result);
            string[] str = { "string", "new string", "superLom", "very big muscle" };
            string newResult = MaximumElementOfArray.FindMaxElement<string>(str, 0, str.Length - 1);
            Console.WriteLine(newResult);
        }
    }
}
