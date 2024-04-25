using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_estudiante
{
    public class Estudiante : Persona
    {
        public string? Carrera { get; set; }
        public string? Matricula { get; set; }

        public Estudiante (string? nombre, string? ciudad, string? carrera, string? matricula): base(nombre, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public override int ObtenerEdad(DateTime fechanNac)
        {

           
            var edad = DateTime.Now.Year - fechanNac.Year;
            
            return edad;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine("Informacion del estudiante registrado: ");
            Console.WriteLine($"Nombre: "+ Nombre);
            Console.WriteLine($"Ciudad: " + Ciudad);
            Console.WriteLine($"Carrera: " + Carrera);
            Console.WriteLine($"Matricula: " + Matricula);

        }

    }
}
