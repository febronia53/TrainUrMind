using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class SubstringComparisonClass
    {
        public static string CompareSubstrings(string str1, string str2, int start1, int length1, int start2, int length2)
        {
            string substr1 = str1.Substring(start1, length1);
            string substr2 = str2.Substring(start2, length2);
            int comparison = string.Compare(substr1, substr2);
            if (comparison < 0)
                return $"Substring '{substr1}' in '{str1}' is less than substring '{substr2}' in '{str2}'.";
            else if (comparison > 0)
                return $"Substring '{substr1}' in '{str1}' is greater than substring '{substr2}' in '{str2}'.";
            else
                return $"Substring '{substr1}' in '{str1}' is equal to substring '{substr2}' in '{str2}'.";
        }
        }
}
