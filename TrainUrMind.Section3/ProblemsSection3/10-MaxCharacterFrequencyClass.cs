using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class MaxCharacterFrequencyClass
    {
        public static (char, int) MaxCharacterFrequency(string inputString)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            foreach (char c in inputString)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }
            int maxFrequency = 0;
            char maxChar = '\0';
            foreach (var entry in charFrequency)
            {
                if (entry.Value > maxFrequency)
                {
                    maxFrequency = entry.Value;
                    maxChar = entry.Key;
                }
            }
            return (maxChar, maxFrequency);
        }
    }
}
