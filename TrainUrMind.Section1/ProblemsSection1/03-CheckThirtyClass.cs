using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckThirtyClass
    {
        public static bool CheckThirty(int num1, int num2)
        {
            return num1 == 30 || num2 == 30 || num1 + num2 == 30;
        }
    }
}
