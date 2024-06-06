using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class SubstringPositionClass
    {

        public static int SearchSubstringPosition(string input, string substring)
        {
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                int j;
                for (j = 0; j < substring.Length; j++)
                {
                    if (input[i + j] != substring[j])
                        break;
                }
                if (j == substring.Length)
                    return i;
            }
            return -1;
        }
    }
}
