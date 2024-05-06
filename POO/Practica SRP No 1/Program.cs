using System;

namespace Practica_SRP_No_1;

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona("Leonidas", 35, "Santo Domingo Este, Los Minas, calle 10", "leonidas@outlook.com");

        Persona persona2 = new Persona("Monica", 25, "Gazcue, Calle 20", "monica@outlook.com");

        PersonaPrinter imprimirData1 = new PersonaPrinter();

        imprimirData1.PrintData(persona1);
        Console.WriteLine();
        imprimirData1.PrintData(persona2);


    }

}