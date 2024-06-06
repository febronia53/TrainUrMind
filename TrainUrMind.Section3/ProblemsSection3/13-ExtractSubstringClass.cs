using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class ExtractSubstringClass
    {
        
            public static string ExtractSubstring(string input, int startPosition, int length)
            {
                char[] result = new char[length];
                for (int i = 0; i < length; i++)
                {
                    result[i] = input[startPosition + i];
                }
                return new string(result);
            }
        }
    }
