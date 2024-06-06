using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckRange100To200Class
    {
        public static bool CheckRange100To200(int num1, int num2)
        {
            return (num1 >= 100 && num1 <= 200) || (num2 >= 100 && num2 <= 200);
        }
    }
}
