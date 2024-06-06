using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CheckVowelConsonantClass
    {
        public static string CheckVowelConsonant(char ch)
        {
            ch = char.ToLower(ch);
            return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')? "The alphabet is a vowel" : "The alphabet is a consonant";
        }
    }
}
