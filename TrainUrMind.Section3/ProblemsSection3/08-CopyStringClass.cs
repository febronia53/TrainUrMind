using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class CopyStringClass
    {
        public static (string, int) CopyString(string inputString)
        {
            string copiedString = inputString;
            return (copiedString, inputString.Length);
        }
    }
}
