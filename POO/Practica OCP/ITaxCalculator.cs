using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_OCP
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(decimal income, decimal deduction);
    }

}
