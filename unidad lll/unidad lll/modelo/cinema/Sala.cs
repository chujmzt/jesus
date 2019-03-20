using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.cinema
{
    class Sala
    {
        private int _id;
        private string _nombre;
        private int _capacidad;
        private bool _estallena;

        private Asiento[] asiento1 = new Asiento[200];
        public Sala()
        {
            _nombre = "B";
            for(int k=0; k <=199; k++)
            {
                asientos[k] = new Asiento();
                asientos[k].Numero = k + 1;
            }
           
        }
        public int capacidad { get; set; }
    }
}
