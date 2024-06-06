using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class CharacterCaseCheckClass
    {
        public static string CharacterCaseCheck(char c)
        {
            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                    return "The character is uppercase.";
                else
                    return "The character is lowercase.";
            }
            return "The character is not an alphabet.";
        }
    }
}
