using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckRange40To50Or50To60Class
    {
         public static bool CheckRange(int num1, int num2)
    {
        return ((num1 >= 40 && num1 <= 50) && (num2 >= 40 && num2 <= 50)) || ((num1 >= 50 && num1 <= 60) && (num2 >= 50 && num2 <= 60));
    }
    }
}
