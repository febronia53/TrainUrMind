using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class CountCharactersClass
    {
        public static (int, int, int) CountCharacters(string inputString)
        {
            int alphabetCount = 0, digitCount = 0, specialCharCount = 0;
            foreach (char c in inputString)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }
            return (alphabetCount, digitCount, specialCharCount);
        }
    }
}
