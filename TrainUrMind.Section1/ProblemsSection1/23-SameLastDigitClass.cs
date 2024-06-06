using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class SameLastDigitClass
    {
        public static bool HaveSameLastDigit(int a, int b)
        {
            return a % 10 == b % 10;
        }
    }
}
