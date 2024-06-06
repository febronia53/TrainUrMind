using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class FindLargestOfThreeClass
    {
        public static string FindLargestOfThree(double num1, double num2, double num3)
        {
            double max= Math.Max(num1, Math.Max(num2, num3));

            if (max == num1) return "The 1st Number is the greatest among three";
            else if (max == num2) return "The 2nd Number is the greatest among three";
            else return "The 3rd Number is the greatest among three";
        }
    }
}
