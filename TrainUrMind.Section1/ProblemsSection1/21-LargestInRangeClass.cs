using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class LargestInRangeClass
    {
        public static int FindLargestInRange(int a, int b)
        {
            if ((a >= 20 && a <= 30) && (b >= 20 && b <= 30))
                return Math.Max(a, b);
            else if (a >= 20 && a <= 30)
                return a;
            else if (b >= 20 && b <= 30)
                return b;
            else
                return 0;
        }
    }
}
