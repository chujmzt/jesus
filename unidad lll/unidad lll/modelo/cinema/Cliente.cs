using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.cinema
{
    class Cliente : Persona

    {
        private string _celular;
        public Cliente() : base()
        {
            _celular = "4686825700";

        }
        public string Celular
        {
            get
            {
                return _celular;
            }
            set
            {
                _celular = value;
            }
        }
    }
}
