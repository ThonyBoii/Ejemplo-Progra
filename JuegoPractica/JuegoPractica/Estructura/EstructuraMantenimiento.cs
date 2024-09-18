using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.EstructuraM
{
    class EstructuraMantenimiento : Estructura
    {
        public int Capacidad { get; set; }

        public EstructuraMantenimiento()
        {
            Nombre = "Estructura de Mantenimiento";
            Precio = 150;
            Vida = 150;
            Capacidad = 5;
        }
    }
}
