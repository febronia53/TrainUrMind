using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section1.ProblemsSection1
{
    public class CheckWithin10Of100Or200Class
    {
        public static bool CheckWithin10Of100Or200(int n)
        {
            return Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10;
        }
    }
}
