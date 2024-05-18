using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP_Refactorizacion
{
    public class Rectangulo : IFiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
