using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equiposdebeisbol
{
    class Equipo
    {
        public string NombreEq;
        public string CiudadOrigen;
        public string Entrenador;
        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            NombreEq = "sin nombre";
            CiudadOrigen = "sin registrar";
            Entrenador = "Sin registrar";
            Jugadores = new List<Jugador>();
           
        }

        public Equipo(string nombreeq)
        {
            NombreEq = nombreeq;
            CiudadOrigen = "sin registrar";
            Entrenador = "Sin registrar";
            Jugadores = new List<Jugador>();

        }



    }
}
