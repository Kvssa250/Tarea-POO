﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_POO
{
    public class Motor
    {
        private int Litros_de_aceite { get; set; }
        private int Potencia { get; set; }
        public Motor(int potencia)
        {
            Potencia = potencia;
            Litros_de_aceite= 0;
        }
    }
}
