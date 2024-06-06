using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CalculateProfitLossClass
    {
        public static string CalculateProfitLoss(double costPrice, double sellingPrice)
        {
            double profitLoss = sellingPrice - costPrice;
            if (profitLoss > 0)
                return $"You can book your profit amount : {profitLoss}";
            else if (profitLoss < 0)
                return $"You have a loss of amount : {-profitLoss}";
            else
                return "No profit, no loss.";
        }
    }
}
