using JuegoPractica.EstructuraM;
using JuegoPractica.UnidadM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.NodoM
{
    class Nodo
    {
        public List<Unidad> Unidades { get; set; } = new List<Unidad>();
        public List<Estructura> Estructuras { get; set; } = new List<Estructura>();

        //public int dineroAdicional { get; set; }

        public bool EstaVacio()
        {
            return Unidades.Count == 0 && Estructuras.Count == 0;
        }

        public void iniciar(int turno)
        {
            int numUnidades = Fibonacci(turno);
            //dineroAdicional = numUnidades * 100;
        }

        private int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
