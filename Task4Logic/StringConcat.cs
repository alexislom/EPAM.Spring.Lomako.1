using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                throw new ArgumentNullException("You should use strings, not null"); 
            }
            if(IsValid(strOne) && IsValid(strTwo))
            {
                return new string((strOne + strTwo).Distinct().OrderBy(c => c).ToArray());
            }else
            {
                throw new ArgumentException("You should use strings only with a to z letters");
            }
        }

        #region Private intermediate method
        /// <summary>
        /// Checking string for validity
        /// </summary>
        /// <param name="str">reference to string</param>
        /// <returns>bool value (valid or not)</returns>
        /// <remarks>Intermediate method for checking the string for validity</remarks>
        private static bool IsValid(string str)
        {
            return Regex.IsMatch(str, "^[a-z]+$");
        }
        #endregion
    }
}
