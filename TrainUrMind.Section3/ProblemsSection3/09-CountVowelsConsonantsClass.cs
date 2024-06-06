using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class CountVowelsConsonantsClass
    {

        public static (int, int) CountVowelsConsonants(string inputString)
        {
            int vowelsCount = 0, consonantsCount = 0;
            foreach (char c in inputString)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                {
                    vowelsCount++;
                }
                else if (char.IsLetter(c))
                {
                    consonantsCount++;
                }
            }
            return (vowelsCount, consonantsCount);
        }
    }
}
