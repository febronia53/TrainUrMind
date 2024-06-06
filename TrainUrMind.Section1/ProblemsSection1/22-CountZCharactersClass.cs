using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CountZCharactersClass
    {
        public static bool ContainsBetween2And4Z(string str)
        {
            int count = str.Count(c => char.ToLower(c) == 'z');
            return count >= 2 && count <= 4;
        }
    }
}
