using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.UnidadM
{
    class Soldado : Unidad
    {
        public Soldado()
        {
            Nombre = "Soldado";
            Precio = 50;
            Vida = 100;
            Daño = 10;
            Velocidad = 1;
        }
    }
}
