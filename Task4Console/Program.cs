using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4Logic;

namespace Task4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "kkkkaaabbbccc";
            string str2 = "aavvdddeeegggiiijjjrrrtttasfsdgafh";
            string result = StringConcat.MergeTwoStrings(str1, str2);
            Console.WriteLine(result);
        }
    }
}
