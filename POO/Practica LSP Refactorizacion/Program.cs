using Practica_LSP_Refactorizacion;

class Program
{
    static void Main()
    {
        IFiguraGeometrica figura;

        figura = new Rectangulo { Base = 4, Altura = 5 };
        Console.WriteLine($"Área del rectángulo: {figura.CalcularArea()}"); 

        figura = new Cuadrado { Lado = 4 };
        Console.WriteLine($"Área del cuadrado: {figura.CalcularArea()}"); 

        figura = new Cuadrado { Lado = 5 };
        Console.WriteLine($"Área del cuadrado con lado 5: {figura.CalcularArea()}"); 
    }
}