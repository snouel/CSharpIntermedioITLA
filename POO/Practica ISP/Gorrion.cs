using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ISP
{
    class Gorrion : IAveVoladora, IAveCantora, IAvePonedora
    {
        public void Volar()
        {
            Console.WriteLine("El gorrión está volando.");
        }

        public void Cantar()
        {
            Console.WriteLine("El gorrión está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El gorrión está poniendo huevos.");
        }
    }

}
