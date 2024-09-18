using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.EstructuraM
{
    class EstructuraDefensa : Estructura
    {
        public int Daño { get; set; }

        public EstructuraDefensa()
        {
            Nombre = "Estructura de Defensa";
            Precio = 200;
            Vida = 300;
            Daño = 20;
        }
    }
}
