using Practica_LSP;

class Program
{
    static void Main()
    {
        FiguraGeometrica figura;

        // Crear un rectángulo
        figura = new Rectangulo { Base = 4, Altura = 5 };
        Console.WriteLine($"Área del rectángulo: {figura.CalcularArea()}"); // Debe ser 20

        // Crear un cuadrado
        figura = new Cuadrado { Base = 4, Altura = 4 };
        Console.WriteLine($"Área del cuadrado: {figura.CalcularArea()}"); // Esperamos 16, pero no es correcto

        // Ejemplo que demuestra la violación del LSP
        figura = new Cuadrado { Base = 4, Altura = 5 };
        Console.WriteLine($"Área del cuadrado con base 4 y altura 5: {figura.CalcularArea()}"); // Resultado incorrecto
    }
}