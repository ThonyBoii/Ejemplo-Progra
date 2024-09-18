using JuegoPractica.UnidadM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica.Actor
{
    class Enemigo
    {
        public List<Unidad> Unidades { get; set; } = new List<Unidad>();
        private int fibonacciTurno = 0;

        private int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public void CrearUnidades()
        {
            int numUnidades = Fibonacci(fibonacciTurno++);
            Random rand = new Random();

            for (int i = 0; i < numUnidades; i++)
            {
                int tipoUnidad = rand.Next(1, 100);
                if (tipoUnidad < 60) // Mayor probabilidad de soldados
                {
                    Unidades.Add(new Soldado());
                }
                else if (tipoUnidad < 90) // Menor probabilidad de tanques
                {
                    Unidades.Add(new Tanque());
                }
                else // Aún menor probabilidad de helicópteros
                {
                    Unidades.Add(new Helicoptero());
                }
            }
        }
    }
}
