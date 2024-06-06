using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class GetNumberOfDaysInMonthClass
    {
        public static string GetNumberOfDaysInMonth(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return "Month have 31 days";
                case 4:
                case 6:
                case 9:
                case 11:
                    return "Month have 30 days";
                case 2:
                    return "Month have 28 or 29 days";
                default:
                    return "Invalid Month Number";
            }
        }
    }
}
