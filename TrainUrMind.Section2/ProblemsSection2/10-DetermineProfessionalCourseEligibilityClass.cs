using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class DetermineProfessionalCourseEligibilityClass
    {
        public static bool DetermineProfessionalCourseEligibility(int math, int phy, int chem)
        {
            int total = math + phy + chem;
            return (math >= 65 && phy >= 55 && chem >= 50 && total >= 180) || (total >= 140 && math >= 65);
        }
    }
}
