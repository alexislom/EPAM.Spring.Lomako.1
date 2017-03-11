using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Logic
{
    public static class StringConcat
    {
        public static string MergeTwoStrings(string strOne, string strTwo)
        {
            if (strOne == null || strTwo == null)
            {
                throw new ArgumentNullException(strOne == null ? nameof(strOne) : nameof(strTwo));
            }

            return new string((strOne + strTwo).Distinct().OrderBy(c => c).ToArray());
        }
    }
}
