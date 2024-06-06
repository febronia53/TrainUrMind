using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class SubstringOccurrenceCountClass
    {
        public static int CountSubstringOccurrences(string input, string substring)
        {
            int count = 0;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                int j;
                for (j = 0; j < substring.Length; j++)
                {
                    if (input[i + j] != substring[j])
                        break;
                }
                if (j == substring.Length)
                {
                    count++;
                    i = i + j - 1;
                }
            }
            return count;
        }
    }
}
