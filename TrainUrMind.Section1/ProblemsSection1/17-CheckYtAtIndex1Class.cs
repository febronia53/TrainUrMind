using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckYtAtIndex1Class
    {
        public static string CheckYtAtIndex1(string str)
        {
            if (str.Length > 1 && str.Substring(1, 2).Equals("yt"))
                return str.Remove(1, 2);
            return str;
        }
    }
}
