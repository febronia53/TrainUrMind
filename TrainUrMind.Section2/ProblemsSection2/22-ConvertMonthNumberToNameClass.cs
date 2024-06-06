using System;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class ConvertMonthNumberToNameClass
    {
        public static string ConvertMonthNumberToName(int monthNumber)
        {
            string[] months = {"", "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };
            if (monthNumber >= 1 && monthNumber <= 12)
            {
                return months[monthNumber];
            }
            else
            {
                return "Invalid month number";
            }
        }
    }
}
