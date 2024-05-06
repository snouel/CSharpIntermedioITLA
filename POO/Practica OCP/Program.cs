using System;


namespace Practica_OCP
{

    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de TaxCalculator
            TaxCalculator taxCalculator = new TaxCalculator();

            // Ejemplo de cálculo de impuestos para un país específico (India, USA, UK)
            decimal income = 50000; // Ingresos totales
            decimal deduction = 10000; // Deducciones
            string country = "India"; // País

            // Calcular impuesto y mostrar el resultado
            decimal taxAmount = taxCalculator.Calculate(income, deduction, country);
            Console.WriteLine($"El impuesto a pagar en {country} es: {taxAmount}");

            // Repetir para otros países si es necesario...
        }
    }

}