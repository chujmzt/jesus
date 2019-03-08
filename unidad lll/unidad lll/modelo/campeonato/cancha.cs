using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.campeonato
{
    class cancha
    {
        //Propiedades de la clase
        private int _id;
        private string _nombre;
        private string _ubicacion;
        private string _tipo;//soccer,futbol 7

        //Metodo Getter's y setter's
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string ubicacion { get; set; }
    }
}
