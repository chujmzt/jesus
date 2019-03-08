using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.campeonato
{
    class Arbitro:Persona
    {
        //Atributos
        private int aniosExperiencia;
        private bool tieneGafete;

        //Metodos Gatter's y setter's
        public int AniosExperiencia { get; set; }
        public bool TieneGafete { get; set; }

    }
}
