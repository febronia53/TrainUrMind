using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class SubstringComparisonCultureClass
    {
        public static string CompareSubstringsTurkishCulture(string str1, string str2, int start1, int length1, int start2, int length2)
        {
            string substr1 = str1.Substring(start1, length1);
            string substr2 = str2.Substring(start2, length2);
            int comparison = string.Compare(substr1, substr2, true, new CultureInfo("tr-TR"));
            return comparison == 0 ? $"Ignore case, Turkish culture: Substring '{substr1}' in '{str1}' is equal to substring '{substr2}' in '{str2}'." : $"Ignore case, Turkish culture: Substring '{substr1}' in '{str1}' is not equal to substring '{substr2}' in '{str2}'.";
        }

        public static string CompareSubstringsInvariantCulture(string str1, string str2, int start1, int length1, int start2, int length2)
        {
            string substr1 = str1.Substring(start1, length1);
            string substr2 = str2.Substring(start2, length2);
            int comparison = string.Compare(substr1, substr2, true, CultureInfo.InvariantCulture);
            return comparison == 0 ? $"Ignore case, invariant culture: Substring '{substr1}' in '{str1}' is equal to substring '{substr2}' in '{str2}'." : $"Ignore case, invariant culture: Substring '{substr1}' in '{str1}' is not equal to substring '{substr2}' in '{str2}'.";
        }
    }
}
