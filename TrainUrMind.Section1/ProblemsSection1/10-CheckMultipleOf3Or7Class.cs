using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckMultipleOf3Or7Class
    {
        public static bool CheckMultipleOf3Or7(int num)
        {
            return num % 3 == 0 || num % 7 == 0;
        }
    }
}
