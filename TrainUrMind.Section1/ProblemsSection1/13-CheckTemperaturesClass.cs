using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckTemperaturesClass
    {
        public static bool CheckTemperatures(int temp1, int temp2)
        {
            return (temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0);
        }
    }
}
