using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class FourCopiesOfFirstTwoClass
    {
        public static string FourCopiesOfFirstTwo(string str)
        {
            if (str.Length < 2) return str;
            string firstTwo = str.Substring(0, 2);
            return string.Concat(firstTwo, firstTwo, firstTwo, firstTwo);
        }
    }
}
