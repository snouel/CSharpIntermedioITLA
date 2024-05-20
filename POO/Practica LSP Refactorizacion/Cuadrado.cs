using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP_Refactorizacion
{
    public class Cuadrado : IFiguraGeometrica
    {
        public double Lado { get; set; }

        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }


}
