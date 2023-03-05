using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Coche
    {
        private Motor motor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double precio_Acumulado { get; set; }

        public Carro(string marca, string modelo)
        { 
            Marca = marca;
            Modelo = modelo;
        }

        public void acumularAveria()
        { 
            
        }
    }
}
