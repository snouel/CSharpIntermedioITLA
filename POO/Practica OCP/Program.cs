using System;


namespace Practica_OCP
{

    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxCalculator = new TaxCalculator();

            decimal income = 50000; 
            decimal deduction = 10000; 
            string country = "India"; 

            
            decimal taxAmount = taxCalculator.Calculate(income, deduction, country);
            Console.WriteLine($"El impuesto a pagar en {country} es: {taxAmount}");

            
        }
    }

}