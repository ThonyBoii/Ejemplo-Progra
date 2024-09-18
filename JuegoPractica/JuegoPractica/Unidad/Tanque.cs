using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.UnidadM
{
    class Tanque : Unidad
    {
        public Tanque()
        {
            Nombre = "Tanque";
            Precio = 150;
            Vida = 200;
            Daño = 30;
            Velocidad = 2;
        }
    }
}
