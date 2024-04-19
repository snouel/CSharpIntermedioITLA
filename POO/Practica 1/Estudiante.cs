using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante (string nombre, int edad, string ciudad, string carrera, string matricula) : base(nombre, edad, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public void MostrarInfoEstudiante()
        {
            Console.WriteLine($"Nombre del estudiante: {Nombre}");
            Console.WriteLine($"Edad del estudiante: {Edad}");
            Console.WriteLine($"Ciudad donde reside el estudiante: {Ciudad}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matricula: {Matricula}");
        }

    }
}
