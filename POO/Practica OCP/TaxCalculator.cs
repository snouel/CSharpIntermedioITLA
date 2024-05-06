using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_OCP
{
    public class TaxCalculator
    {
        private TaxCalculatorFactory taxCalculatorFactory;

        public TaxCalculator()
        {
            taxCalculatorFactory = new TaxCalculatorFactory();
        }

        public decimal Calculate(decimal income, decimal deduction, string country)
        {
            var taxCalculator = taxCalculatorFactory.GetTaxCalculator(country);
            return taxCalculator.CalculateTax(income, deduction);
        }
    }

}
