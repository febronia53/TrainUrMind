using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class WordComparisonClass
    {

        public static string CompareWords(string str1, string str2)
        {
            return
                $"case = Case (CurrentCulture): {string.Equals(str1, str2, StringComparison.CurrentCulture)}\n" +
                $"case = Case (CurrentCultureIgnoreCase): {string.Equals(str1, str2, StringComparison.CurrentCultureIgnoreCase)}\n" +
                $"case = Case (InvariantCulture): {string.Equals(str1, str2, StringComparison.InvariantCulture)}\n" +
                $"case = Case (InvariantCultureIgnoreCase): {string.Equals(str1, str2, StringComparison.InvariantCultureIgnoreCase)}\n" +
                $"case = Case (Ordinal): {string.Equals(str1, str2, StringComparison.Ordinal)}\n" +
                $"case = Case (OrdinalIgnoreCase): {string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase)}";
        }
    }
}
