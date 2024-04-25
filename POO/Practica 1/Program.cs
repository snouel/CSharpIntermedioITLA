using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1. Creación de una clase

Crea una clase llamada "Persona" con atributos como nombre, edad y ciudad.
Define un constructor para inicializar los atributos de la clase.
Crea métodos para mostrar la información de la persona y calcular su edad en años.

2. Implementación de Herencia

Crea una clase llamada "Estudiante" que herede de la clase "Persona".
Agrega atributos específicos para el estudiante, como carrera y matrícula.
Define un método para mostrar la información completa del estudiante.

3. Implementación de Polimorfismo

Crea una clase abstracta llamada "Figura" con un método abstracto para calcular el área.
Crea clases derivadas de "Figura" como "Rectángulo", "Círculo" y "Triángulo".
Implementa el método abstracto "calcularÁrea" en cada clase derivada.
Crea una aplicación de consola que cree objetos de las clases "Rectángulo", "Círculo" y "Triángulo", calcule su área y muestre el resultado.
*/

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa estudiantes: ");
            Console.WriteLine();

            string rol = " ";
            bool rolValido = false;
            while (!rolValido)
            {
                Console.WriteLine("Especifique su rol: (estudiante o profesor)");
                rol = Console.ReadLine();

                if (rol.ToLower() == "estudiante" || rol.ToLower() == "profesor")
                {
                    rolValido = true;
                }
                else
                {
                    Console.WriteLine("Rol ingresado no válido. Inténtalo de nuevo.");
                }
            }

            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su residencia: ");
            string ciudad = Console.ReadLine();

            DateTime fechaNac = DateTime.MinValue;
            bool fechaValida = false;
            while (!fechaValida)
            {
                Console.WriteLine("Ingrese la fecha de nacimiento (Formato: dd/MM/yyyy): ");
                string fechaNacimientoStr = Console.ReadLine();

                if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNac))
                {
                    fechaValida = true;
                }
                else
                {
                    Console.WriteLine("Formato de fecha incorrecto. Inténtalo de nuevo.");
                }
            }

            if (rol.ToLower() == "estudiante")
            {
                Console.WriteLine("Ingrese su carrera: ");
                string carrera = Console.ReadLine();

                Console.WriteLine("Ingrese su Matricula: ");
                string matricula = Console.ReadLine();

                Estudiante estudiante1 = new Estudiante(nombre, ciudad, carrera, matricula);
                estudiante1.MostrarInfo();

                Console.WriteLine($"Usted tiene {estudiante1.ObtenerEdad(fechaNac)} años");
            }
            else
            {
                Profesor profesor1 = new Profesor(nombre, ciudad);
                profesor1.MostrarInfo();
                Console.WriteLine($"Su edad es {profesor1.ObtenerEdad(fechaNac)} años");
              
            }
        }



    }


}
