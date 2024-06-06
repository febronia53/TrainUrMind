using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class ExchangeFirstLastClass
    {
        public static string ExchangeFirstLast(string str)
        {
            return str.Length <= 1 ? str :
                str[^1] + str.Substring(1, str.Length - 2) + str[0];
        }
    }
}
