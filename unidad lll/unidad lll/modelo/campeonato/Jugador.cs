using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.campeonato
{
    class Jugador:Persona
    {
        //propiedades de la clase
        private int _Numero;
        private string _Posicion;

        //enlace con la clase Equipo
        private Equipo _equipe;

        //metodos getter's y Setter
        public int Numero { get; set; }
        public int  Posicion { get; set; }
        public Equipo Equipe { get; set; }
    }
}
