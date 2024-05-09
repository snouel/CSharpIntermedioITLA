using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_OCP
{
    public class TaxCalculatorFactory
    {
        private Dictionary<string, ITaxCalculator> countryTaxCalculators;

        public TaxCalculatorFactory()
        {
            countryTaxCalculators = new Dictionary<string, ITaxCalculator>
        {
            {"India", new IndiaTaxCalculator()},
            {"USA", new USATaxCalculator()},
            {"UK", new UKTaxCalculator()}
        };
        }

        public ITaxCalculator GetTaxCalculator(string country)
        {
            if (!countryTaxCalculators.ContainsKey(country))
            {
                throw new ArgumentException("País no compatible", nameof(country));
            }

            return countryTaxCalculators[country];
        }
    }

}
