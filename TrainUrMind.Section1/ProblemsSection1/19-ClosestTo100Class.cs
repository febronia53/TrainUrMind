using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class ClosestTo100Class
    {
        public static int ClosestTo100(int num1, int num2)
        {
            int diff1 = Math.Abs(num1 - 100);
            int diff2 = Math.Abs(num2 - 100);
            if (diff1 == diff2) return 0;
            return (diff1 < diff2) ? num1 : num2;
        }
    }
}
