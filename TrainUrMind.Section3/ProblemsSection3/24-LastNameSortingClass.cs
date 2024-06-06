using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section3.ProblemsSection3
{
    internal class LastNameSortingClass
    {
        public static string[] SortByLastName(string[] names)
        {
            Array.Sort(names, (x, y) =>
            {
                string lastNameX = x.Substring(x.LastIndexOf(' ') + 1);
                string lastNameY = y.Substring(y.LastIndexOf(' ') + 1);
                return string.Compare(lastNameX, lastNameY);
            });
            return names;
        }
    }
}
