using System;

namespace Practica_1;


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
        Console.WriteLine("La informacion de la persona proporcionada: ");
        Console.WriteLine(Nombre);
        Console.WriteLine(Ciudad);

    }
}
 