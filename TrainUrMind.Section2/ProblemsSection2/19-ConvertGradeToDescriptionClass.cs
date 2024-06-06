using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class ConvertGradeToDescriptionClass
    {
        public static string ConvertGradeToDescription(char grade)
        {
            switch (grade)
            {
                case 'E':
                    return "Excellent";
                case 'V':
                    return "Very Good";
                case 'G':
                    return "Good";
                case 'A':
                    return "Average";
                case 'F':
                    return "Fail";
                default:
                    return "Invalid Grade";
            }
        }
    }
}
