using System;

namespace Programa_figuras
{


    /* 3.Implementación de Polimorfismo

    Crea una clase abstracta llamada "Figura" con un método abstracto para calcular el área.
    Crea clases derivadas de "Figura" como "Rectángulo", "Círculo" y "Triángulo".
    Implementa el método abstracto "calcularÁrea" en cada clase derivada.
    Crea una aplicación de consola que cree objetos de las clases "Rectángulo", "Círculo" y "Triángulo", calcule su área y muestre el resultado.
    */

    public class Program
    {

        static void Main(string[] args)
        {

          

            bool validacionFigura = false;

            
            while (!validacionFigura)
            {
                Console.WriteLine("A cual figura desea calcular el area?");
                string figura = Console.ReadLine();

                if (figura.ToLower() == "circulo" || figura.ToLower() == "rectangulo" || figura.ToLower() == "triangulo")
                {
                    validacionFigura = true;

                    if (figura == "circulo")
                    {
                        Circulo circulo = new Circulo { Radio = 4 };
                        Console.WriteLine("Area del circulo: " + circulo.CalcularArea());
                    }
                    else if (figura == "triangulo")
                    {
                        Triangulo triangulo = new Triangulo { Base = 6, Altura = 4 };
                        Console.WriteLine("Area del triangulo: " + triangulo.CalcularArea());
                    }
                    else
                    {
                        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 3 };
                        Console.WriteLine("Area del rectangulo: " + rectangulo.CalcularArea());
                    }
                }
                else
                {
                    Console.WriteLine("Debe introducir (circulo, rectangulo o triangulo).");
                    
                }
            }

            
        }



    }

}