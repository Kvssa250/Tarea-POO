using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    internal class Garaje
    {
        public Coche coche { get; set; }
        public string Averia { get; set; }
        public int Cant_coches { get; set; }
        public void Aceptar_Coche(int Cant_coches, int Averia)
        {
            bool z = true;
            if (Cant_coches > 1)
            {
                Console.WriteLine("El garaje esta lleno");
                z = false;
            }
        }
        public void Devolver_Coche(int Cant_coches, int Averia)
        { 
            if (Cant_coches > 1) 
            {
                Cant_coches = Cant_coches - 1;
            }
        }
    }
}
