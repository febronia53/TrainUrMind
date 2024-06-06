using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.Section2
{
    internal class CategorizeTemperatureClass
    {
        public static string CategorizeTemperature(int temperature)
        {
            if (temperature < 0)
            {
                return "Freezing weather";
            }
            else if (temperature >= 0 && temperature < 10)
            {
                return "Very Cold weather";
            }
            else if (temperature >= 10 && temperature < 20)
            {
                return "Cold weather";
            }
            else if (temperature >= 20 && temperature < 30)
            {
                return "Normal in Temp";
            }
            else if (temperature >= 30 && temperature < 40)
            {
                return "Its Hot";
            }
            else
            {
                return "Its Very Hot";
            }
        }
    }
}
