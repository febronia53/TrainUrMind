using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class ClassCalculateQuadraticRootsClass
    {
        public static string CalculateQuadraticRoots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return $"Roots are real and different: {root1}, {root2}";
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return $"Roots are real and same: {root}";
            }
            else
            {
                return "Roots are imaginary";
            }
        }
    }
}
