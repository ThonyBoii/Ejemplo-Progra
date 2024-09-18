using JuegoPractica.Actor;
using JuegoPractica.NodoM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPractica
{
    class Juego
    {
        public Jugador jugador = new Jugador();
        public Enemigo enemigo = new Enemigo();
        public List<Nodo> Mapa = new List<Nodo>();

        public Juego()
        {
            // Crear un mapa con 5 nodos
            for (int i = 0; i < 5; i++)
            {
                Mapa.Add(new Nodo());
            }
        }

        public void Jugar()
        {
            int turno = 0;
            bool juegoTerminado = false;

            while (!juegoTerminado)
            {
                Console.WriteLine($"Turno {turno + 1}");
                
                //Inicio nodo
                Nodo actual = Mapa.FirstOrDefault();
                actual.iniciar(turno);

                //jugador.Dinero += actual.dineroAdicional;
                Console.WriteLine($"Dinero actual {jugador.Dinero}");

                // Lógica de turno del jugador
                MenuTurnoJugador();

                // Lógica de turno del enemigo
                enemigo.CrearUnidades();



                //// Verificar si el jugador ha ganado o perdido
                //if (Mapa[4].Unidades.Exists(u => jugador.Unidades.Contains(u)))
                //{
                //    Console.WriteLine($"¡Has ganado en {turno + 1} turnos!");
                //    juegoTerminado = true;
                //}
                //else if (jugador.Estructuras.Count == 0)
                //{
                //    Console.WriteLine($"Has perdido después de {turno + 1} turnos.");
                //    juegoTerminado = true;
                //}

                turno++;
            }
        }

        private void MenuTurnoJugador()
        {
            Console.WriteLine("Opciones:");
            Console.WriteLine("1. Ver estructuras");
            Console.WriteLine("2. Ver unidades");
            Console.WriteLine("3. Crear estructura");
            Console.WriteLine("4. Crear unidad");
            Console.WriteLine("5. Ver enemigos");
            Console.WriteLine("6. Ver nodos");
            Console.WriteLine("7. Pasar turno");

            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    VerEstructuras();
                    break;
                case 2:
                    VerUnidades();
                    break;
                case 3:
                    CrearEstructura();
                    break;
                case 4:
                    CrearUnidad();
                    break;
                case 5:
                    VerEnemigos();
                    break;
                case 6:
                    VerNodos();
                    break;
                case 7:
                    // Pasar turno
                    break;
            }
        }

        private void VerEstructuras()
        {
            Console.WriteLine("Estructuras del jugador:");
            foreach (var estructura in jugador.Estructuras)
            {
                Console.WriteLine($"{estructura.Nombre} - Vida: {estructura.Vida}");
            }
        }

        private void VerUnidades()
        {
            Console.WriteLine("Unidades del jugador:");
            foreach (var unidad in jugador.Unidades)
            {
                Console.WriteLine($"{unidad.Nombre} - Vida: {unidad.Vida}");
            }
        }

        private void CrearEstructura()
        {
            Console.WriteLine("Tipo de estructura a crear: (recoleccion, mantenimiento, defensa)");
            string tipo = Console.ReadLine();
            jugador.CrearEstructura(tipo);
        }

        private void CrearUnidad()
        {
            Console.WriteLine("Tipo de unidad a crear: (soldado, tanque, helicoptero)");
            string tipo = Console.ReadLine();
            jugador.CrearUnidad(tipo);
        }

        private void VerEnemigos()
        {
            Console.WriteLine("Unidades enemigas:");
            foreach (var unidad in enemigo.Unidades)
            {
                Console.WriteLine($"{unidad.Nombre} - Vida: {unidad.Vida}");
            }
        }

        private void VerNodos()
        {
            for (int i = 0; i < Mapa.Count; i++)
            {
                Console.WriteLine($"Nodo {i + 1}:");
                if (Mapa[i].EstaVacio())
                {
                    Console.WriteLine("Vacío.");
                }
                else
                {
                    Console.WriteLine("Unidades:");
                    foreach (var unidad in Mapa[i].Unidades)
                    {
                        Console.WriteLine($"{unidad.Nombre} - Vida: {unidad.Vida}");
                    }

                    Console.WriteLine("Estructuras:");
                    foreach (var estructura in Mapa[i].Estructuras)
                    {
                        Console.WriteLine($"{estructura.Nombre} - Vida: {estructura.Vida}");
                    }
                }
            }
        }
    }
}
