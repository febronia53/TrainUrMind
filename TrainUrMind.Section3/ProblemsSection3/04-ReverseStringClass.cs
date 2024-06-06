using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class ReverseStringClass
    {
        public static void PrintReverseString(string inputString)
        {
            Console.WriteLine("Individual characters of the string in reverse order:");
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(inputString[i]);
            }
        }
    }
}
