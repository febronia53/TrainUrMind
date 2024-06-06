using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class SortStringArrayClass
    {
        public static string SortString(string input)
        {
            char[] charArray = input.Replace(" ", "").ToCharArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}
