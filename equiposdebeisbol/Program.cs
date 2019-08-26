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

            Jugador Equipo1 =
                new Jugador("Chayanne", "1233r3");

            Jugador Equipo2 =
                new Jugador("Chabelo", "2343r");

            jugadores.Add(Equipo1);
            jugadores.Add(Equipo2);

            Jugador Patiño = new Jugador ("Patiño1","12341");
            Jugador Patiño2 = new Jugador("Patiño2", "12342");
            Jugador Patiño3 = new Jugador("Patiño3", "12343");
            Jugador Patiño4 = new Jugador("Patiño4", "12344");
            Jugador Patiño5 = new Jugador("Patiño5", "12345");
            Jugador Patiño6 = new Jugador("Patiño6", "12346");
            Jugador Patiño7 = new Jugador("Patiño7", "12347");
            Jugador Patiño8 = new Jugador("Patiño8", "12348");
            Jugador Patiño9 = new Jugador("Patiño9", "12349");

            Jugador Chayanne = new Jugador("Chayanne", "1234er");
            Jugador Chayanne1 = new Jugador("Chayanne1", "1234er1");
            Jugador Chayanne2 = new Jugador("Chayanne2", "1234er2");
            Jugador Chayanne3 = new Jugador("Chayanne3", "1234er3");
            Jugador Chayanne4 = new Jugador("Chayanne4", "1234er4");
            Jugador Chayanne5 = new Jugador("Chayanne5", "1234er5");
            Jugador Chayanne6 = new Jugador("Chayanne6", "1234er6");
            Jugador Chayanne7 = new Jugador("Chayanne7", "1234er7");
            Jugador Chayanne8 = new Jugador("Chayanne8", "1234er8");

            Equipo1.Jugadores.Add(Patiño);


        }
    }
}
