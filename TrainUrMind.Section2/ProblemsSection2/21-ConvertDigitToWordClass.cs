using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class ConvertDigitToWordClass
    {
        public static string ConvertDigitToWord(int digit)
        {
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            if (digit >= 0 && digit <= 9)
            {
                return words[digit];
            }
            else
            {
                return "Invalid digit";
            }
        }
    }
}
