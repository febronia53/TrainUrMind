using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class AbsoluteDifferenceClass
    {
        public static int AbsoluteDifference(int n)
        {
            int difference = Math.Abs(n - 51);
            return n > 51 ? difference * 3 : difference;
        }
    }
}
