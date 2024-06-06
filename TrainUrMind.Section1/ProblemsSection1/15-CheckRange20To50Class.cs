using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckRange20To50Class
    {
        public static bool CheckRange20To50(int num1, int num2, int num3)
        {
            return (num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50) || (num3 >= 20 && num3 <= 50);
        }
    }
}
