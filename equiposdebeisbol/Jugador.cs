using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equiposdebeisbol
{
    class Jugador
    {
        public string Nombre;
        public string Numero;

        public Jugador()
        {
            Nombre = "sin registrar";
            Numero = "sin registrar";

        }
        public Jugador(string nombre)
        {
            Nombre = nombre;
          
        }

        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
