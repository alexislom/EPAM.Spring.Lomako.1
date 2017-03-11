using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Logic
{
    /// <summary>
    /// Class which contains method of merge two strings 
    /// </summary>
    /// <remarks>merge two strings without duplicate letters and in alphabetical order</remarks>
    public static class StringConcat
    {
        /// <summary>
        /// Merge two strings
        /// </summary>
        /// <param name="strOne">reference to the first string</param>
        /// <param name="strTwo">reference to the second string</param>
        /// <returns>new string</returns>
        public static string MergeTwoStrings(string strOne, string strTwo)
        {
            if (strOne == null || strTwo == null)
            {
                throw new ArgumentNullException("You should use strings not null"); 
            }
            return new string((strOne + strTwo).Distinct().OrderBy(c => c).ToArray());
        }
    }
}
