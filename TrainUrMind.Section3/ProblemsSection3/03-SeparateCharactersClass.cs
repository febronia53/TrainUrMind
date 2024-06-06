using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class SeparateCharactersClass
    {
        public static void SeparateCharacters(string inputString)
        {
            Console.WriteLine("Individual characters from the string:");
            foreach (char c in inputString)
            {
                Console.WriteLine(c);
            }
        }
    }
}
