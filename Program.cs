using System;

namespace Tarea_POO
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Garaje garaje = new Garaje();
            Coche coche = new Coche("Ford", "Mustang");
            Coche coche2 = new Coche("Chevrolet", "Camaro");

            Console.ReadKey();
        }
    }
}