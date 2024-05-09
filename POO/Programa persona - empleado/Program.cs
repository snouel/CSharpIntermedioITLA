using Programa_persona___empleado;

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona("Manuel", 40);
        PersonaPrinter personaPrinter = new PersonaPrinter();
        personaPrinter.Imprimir(persona);

        Empleado empleado = new Empleado("Pedro", 20, 50000);
        EmpleadoPrinter empleadoPrinter = new EmpleadoPrinter();
        empleadoPrinter.Imprimir(empleado); 

    }
}