
namespace Programa_persona___empleado
{
    class Empleado : Persona
    {
        public double Sueldo {get ; set;}

        public Empleado(string nombre, int edad, double sueldo): base (nombre, edad)
        {
            Sueldo = sueldo;
        }

    }

    class EmpleadoPrinter
    {
        public void Imprimir(Empleado empleado)
        {
            Console.WriteLine($"Nombre: {empleado.Nombre}, Edad: {empleado.Edad}, Sueldo: {empleado.Sueldo}");
        }
    }
}
