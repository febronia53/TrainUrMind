using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CheckTriangleValidityClass
    {
        public static string CheckTriangleValidity(int angle1, int angle2, int angle3)
        {
            return angle1 + angle2 + angle3 == 180? "The triangle is valid.": "The triangle is not valid.";
        }
    }
}
