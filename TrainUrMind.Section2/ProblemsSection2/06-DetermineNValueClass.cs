using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    public class DetermineNValueClass
    {
        public static int DetermineNValue(int m)
        {
            if (m > 0)
            {
                return 1;
            }
            else if (m == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
