using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class InsertSubstringClass
    {
        public static string InsertSubstring(string input, string toSearch, string toInsert)
        {
            int pos = input.IndexOf(toSearch);
            if (pos < 0)
                return input;
            return input.Substring(0, pos) + toInsert + input.Substring(pos);
        }
    }
}
