using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class RemoveCharAtClass
    {
        public static string RemoveCharAt(string str, int index)
        {
            return index < str.Length && index > -1 ?
                str.Remove(index, 1) : "Index is out of string length ";
        }
    }
}
