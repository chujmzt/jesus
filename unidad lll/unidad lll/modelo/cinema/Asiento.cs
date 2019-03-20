using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.cinema
{
    class Asiento
    {
        private int _numero;
        private bool _estaDisponible;

        public Asiento()
        {
            _numero = 10;
        }        
        public int Numero { get; set;}
        public string EstaDisponible { get; set; }
    }
}
