using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class AddFirst3CharsFrontBackClass
    {
        public static string AddFirst3CharsFrontBack(string str)
        {
            string first3 = (str.Length < 3) ? str : str.Substring(0, 3);
            return first3 + str + first3;
        }
    }
}
