using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP
{
    class Pinguino : IAveNadadora, IAvePonedora
    {
        public void Nadar()
        {
            Console.WriteLine("El pingüino está nadando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pingüino está poniendo huevos.");
        }
    }
}
