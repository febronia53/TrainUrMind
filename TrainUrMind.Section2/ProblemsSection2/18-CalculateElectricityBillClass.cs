using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUrMind.Section2.ProblemsSection2
{
    internal class CalculateElectricityBillClass
    {

        public static void CalculateElectricityBill(int customerId, string customerName, int unitsConsumed)
        {
            double chargePerUnit = 0;
            double totalAmount = 0;

            if (unitsConsumed <= 199)
            {
                chargePerUnit = 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }

            totalAmount = unitsConsumed * chargePerUnit;

            if (totalAmount > 400)
            {
                double surcharge = totalAmount * 0.15;
                totalAmount += surcharge;
            }

            if (totalAmount < 100)
            {
                totalAmount = 100;
            }

            Console.WriteLine($"Customer IDNO: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Units Consumed: {unitsConsumed}");
            Console.WriteLine($"Amount Charges @Rs. {chargePerUnit:F2} per unit: {totalAmount:F2}");
            Console.WriteLine($"Surcharge Amount: {totalAmount - unitsConsumed * chargePerUnit:F2}");
            Console.WriteLine($"Net Amount Paid By the Customer: {totalAmount:F2}");
        }
    }
}

