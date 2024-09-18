using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.UnidadM
{
    class Helicoptero : Unidad
    {
        public Helicoptero()
        {
            Nombre = "Helicóptero";
            Precio = 200;
            Vida = 150;
            Daño = 40;
            Velocidad = 3;
        }
    }
}
