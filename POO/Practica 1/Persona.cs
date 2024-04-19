using System;

namespace Practica_1;


public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Ciudad { get; set; }


    public Persona (string nombre, int edad, string ciudad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Edad = edad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Ciudad: {Ciudad}");

    }

    public void  EdadEnAnios()
    {
        Console.WriteLine($"El usuario {Nombre} tiene {Edad} años");
    }


}
 