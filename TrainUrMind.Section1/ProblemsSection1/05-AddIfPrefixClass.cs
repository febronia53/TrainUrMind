using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class AddIfPrefixClass
    {
        public static string AddIfPrefix(string str)
        {
            return str.StartsWith("if") ? str : "if " + str;
        }
    }
}
