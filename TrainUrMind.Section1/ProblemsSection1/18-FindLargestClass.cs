using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class FindLargestClass
    {
        public static int FindLargest(int num1, int num2, int num3)
        {
            return Math.Max(num1, Math.Max(num2, num3));
        }
    }
}
