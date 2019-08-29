using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equiposdebeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            List<Equipo> equipos =
                new List<Equipo>();

            Equipo equipo1 = new Equipo("comunismo");
            equipo1.Entrenador = "patio";
            equipo1.CiudadOrigen = "df";

            equipo1.Jugadores.Add(
                new Jugador("comunista 1", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 2", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 3", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 4", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 5", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 6", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 7", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 8", "qweq2"));
            equipo1.Jugadores.Add(
                new Jugador("comunista 9", "qweq2"));

            Equipo equipo2 = new Equipo("capitalista");
            equipo2.Entrenador = "chayanne";
            equipo2.CiudadOrigen = "San Luis Potosi";

            equipo2.Jugadores.Add(
               new Jugador("capitalista 1", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 2", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 3", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 4", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 5", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 6", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 7", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 8", "qweq3"));
            equipo2.Jugadores.Add(
                new Jugador("capitalista 9", "qweq3"));


            equipos.Add(equipo1);
            equipos.Add(equipo2);

            foreach (Equipo equipo in equipos) 
            {
                Console.WriteLine( " * " + equipo.NombreEq + " de " + equipo.CiudadOrigen);

                foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("-" +
                        jugador.Nombre + " " +
                        jugador.Numero);
                }
            }

        }
    }
}
