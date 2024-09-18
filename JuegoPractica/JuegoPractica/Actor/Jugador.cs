using JuegoPractica.EstructuraM;
using JuegoPractica.UnidadM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.Actor
{
    class Jugador
    {
        public List<Unidad> Unidades { get; set; } = new List<Unidad>();
        public List<Estructura> Estructuras { get; set; } = new List<Estructura>();
        public int Dinero { get; set; } = 500;

        public void CrearEstructura(string tipo)
        {
            if (tipo == "recoleccion" && Dinero >= 100)
            {
                Estructuras.Add(new EstructuraRecoleccion());
                Dinero -= 100;
            }
            else if (tipo == "mantenimiento" && Dinero >= 150)
            {
                Estructuras.Add(new EstructuraMantenimiento());
                Dinero -= 150;
            }
            else if (tipo == "defensa" && Dinero >= 200)
            {
                Estructuras.Add(new EstructuraDefensa());
                Dinero -= 200;
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero.");
            }
        }

        public void CrearUnidad(string tipo)
        {
            if (tipo == "soldado" && Dinero >= 50)
            {
                Unidades.Add(new Soldado());
                Dinero -= 50;
            }
            else if (tipo == "tanque" && Dinero >= 150)
            {
                Unidades.Add(new Tanque());
                Dinero -= 150;
            }
            else if (tipo == "helicoptero" && Dinero >= 200)
            {
                Unidades.Add(new Helicoptero());
                Dinero -= 200;
            }
            else
            {
                Console.WriteLine("No tienes suficiente dinero.");
            }
        }
    }
}
