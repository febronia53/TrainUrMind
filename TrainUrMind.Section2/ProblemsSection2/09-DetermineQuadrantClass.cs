using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class DetermineQuadrantClass
    {
        public static string DetermineQuadrant(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return $"The coordinate point ({x},{y}) lies in the First quadrant.";
            }
            else if (x < 0 && y > 0)
            {
                return $"The coordinate point ({x},{y}) lies in the Second quadrant.";
            }
            else if (x < 0 && y < 0)
            {
                return $"The coordinate point ({x},{y}) lies in the Third quadrant.";
            }
            else if (x > 0 && y < 0)
            {
                return $"The coordinate point ({x},{y}) lies in the Fourth quadrant.";
            }
            else
            {
                return $"The coordinate point ({x},{y}) is at the origin.";
            }
        }
    }
}
