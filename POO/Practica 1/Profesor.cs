using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class Profesor : Persona
    {

        public Profesor(string? nombre, string? ciudad) : base(nombre, ciudad) { }


       
        public override int ObtenerEdad(DateTime fechanNac)
        {
            var edad = DateTime.Now.Year - fechanNac.Year;

            return edad;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("La informacion de la persona proporcionada: ");
            Console.WriteLine(Nombre);
            Console.WriteLine(Ciudad);

        }
    }
}
