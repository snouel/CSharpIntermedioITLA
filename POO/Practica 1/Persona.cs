using System;

namespace Programa_estudiante;


public abstract class Persona
{
    public string? Nombre { get; set; }
    public string? Ciudad { get; set; }

    public Persona (string? nombre, string? ciudad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
    }


    public virtual int ObtenerEdad(DateTime fechanNac)
    {

        var edad = DateTime.Now.Year - fechanNac.Year;

        return edad;
    }


    public virtual void MostrarInfo()
    {
        Console.WriteLine("Informacion de la persona registrada: ");
        Console.WriteLine($"Nombre: " + Nombre);
        Console.WriteLine($"Ciudad: " + Ciudad);

    }
}
 