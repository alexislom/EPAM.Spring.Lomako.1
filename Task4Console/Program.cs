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
            //string s = "adasgafhafdaaagdfhbbbcvssdd";
            //string s2 = new string(s.Distinct().ToArray());
            //Console.WriteLine(s2);
            string str1 = "kkkkaaabbbccc";
            string str2 = "aavvdddeee";
            string sss = StringConcat.MergeTwoStrings(str1, str2);
            Console.WriteLine(sss);
        }
    }
}
