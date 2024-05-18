using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP
{
    class Aguila : IAveVoladora, IAveCazadora, IAvePonedora
    {
        public void Volar()
        {
            Console.WriteLine("El águila está volando.");
        }

        public void Cazar()
        {
            Console.WriteLine("El águila está cazando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El águila está poniendo huevos.");
        }
    }
}
