using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.campeonato
{
    class Jornada
    {
        private int _id;
        private DateTime _fechainico;
        private DateTime _fechafin;
        private bool _isconcluida;

        //Getter´s y Setter´s
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime Fechafin { get; set; }
         public bool IsConcluid { get; set; }
    }
}
