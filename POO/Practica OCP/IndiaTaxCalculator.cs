using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_OCP
{
    public class IndiaTaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(decimal income, decimal deduction)
        {
            decimal taxableIncome = income - deduction;
            decimal taxAmount = 0;

            if (taxableIncome <= 250000)
            {
                taxAmount = 0;
            }
            else if (taxableIncome > 250000 && taxableIncome <= 500000)
            {
                taxAmount = (taxableIncome - 250000) * 0.05m;
            }
            else if (taxableIncome > 500000 && taxableIncome <= 1000000)
            {
                taxAmount = ((taxableIncome - 500000) * 0.1m) + 12500;
            }

            return taxAmount;
        }
    }
}
