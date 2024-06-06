using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class UppercaseLast3CharsClass
    {
        public static string ConvertLast3ToUpper(string str)
        {
            if (str.Length < 3)
                return str.ToUpper();
            else
                return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
        }
    }
}
