using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.EstructuraM
{
    class EstructuraRecoleccion : Estructura
    {
        public int RecoleccionPorTurno { get; set; }

        public EstructuraRecoleccion()
        {
            Nombre = "Estructura de Recolección";
            Precio = 100;
            Vida = 200;
            RecoleccionPorTurno = 10;
        }
    }

}
