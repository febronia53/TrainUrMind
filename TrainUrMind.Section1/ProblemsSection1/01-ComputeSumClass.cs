using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class ComputeSumClass
    {
        public static int ComputeSum(int num1, int num2)
        {
            int sum = num1 + num2;
            return num1 == num2 ? sum * 3 : sum;
        }
    }
}
