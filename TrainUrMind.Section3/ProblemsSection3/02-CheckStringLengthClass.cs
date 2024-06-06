using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class CheckStringLengthClass
    {
        public static int GetStringLength(string inputString)
        {
            int length = 0;
            foreach (char c in inputString)
            {
                length++;
            }
            return length;
        }
    }
}
