using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CategorizeHeightClass
    {
        public static string CategorizeHeight(int height)
        {
            if (height < 150)
            {
                return "The person is Dwarf.";
            }
            else if (height >= 150 && height <= 165)
            {
                return "The person is Average Height.";
            }
            else if (height > 165 && height <= 195)
            {
                return "The person is Tall.";
            }
            else
            {
                return "The person is Giant.";
            }
        }
    }
}
