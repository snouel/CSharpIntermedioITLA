using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_LSP
{
    public class Cuadrado : FiguraGeometrica
    {
        public override double Base
        {
            get => base.Base;
            set
            {
                base.Base = value;
                base.Altura = value; // En un cuadrado, la base y la altura son iguales
            }
        }

        public override double Altura
        {
            get => base.Altura;
            set
            {
                base.Altura = value;
                base.Base = value; // En un cuadrado, la base y la altura son iguales
            }
        }

        // Implementación incorrecta de CalcularArea
        public override double CalcularArea()
        {
            // Incorrectamente calcula el área como si fuera un rectángulo, pero manipula mal los valores
            return base.Base * (base.Altura + 1); // Error intencionado
        }
    }


}
