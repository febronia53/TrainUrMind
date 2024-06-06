using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class ConvertCaseClass
    {
        public static string ConvertCase(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                    result[i] = char.ToUpper(input[i]);
                else if (char.IsUpper(input[i]))
                    result[i] = char.ToLower(input[i]);
                else
                    result[i] = input[i];
            }
            return new string(result);
        }
    }
}
