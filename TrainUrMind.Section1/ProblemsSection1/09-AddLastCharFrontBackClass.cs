using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class AddLastCharFrontBackClass
    {
        public static string AddLastCharFrontBack(string str)
        {
            if (str.Length == 0) return str;
            char lastChar = str[^1];
            return lastChar + str + lastChar;
        }
    }
}
