using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CheckTriangleTypeClass
    {
        public static string CheckTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "This is an Equilateral triangle.";
            }
            else if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                return "This is an Isosceles triangle.";
            }
            else
            {
                return "This is a Scalene triangle.";
            }
        }
    }
}
