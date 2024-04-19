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


            Estudiante estudiante1 = new Estudiante("Rodrigo", 35, "La Romana", "Ingenieria en Sistemas", "A20240105");
            estudiante1.MostrarInfoEstudiante();

            Console.WriteLine();

            Console.WriteLine("Programa figuras: ");
            Console.WriteLine();

            Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 3 };
            Circulo circulo = new Circulo { Radio = 4 };
            Triangulo triangulo = new Triangulo { Base = 6, Altura = 4 };

            // Calcular y mostrar el área de cada figura
            Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
            Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
            Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());

        }

     

    }


}
