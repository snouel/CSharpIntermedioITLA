using System;

namespace Programa_persona___empleado
{
     class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

    }

    class PersonaPrinter
    {
        public void Imprimir (Persona persona)
        {
          Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }
    }
}
