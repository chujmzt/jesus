using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad_lll.modelo.campeonato
{
    class Campeonato
    {
        private int _id;
        private string _nombre;
        private DateTime _fechainicio;
        private DateTime _fechatermino;
        private string _jornadas;

        //Getter´s y Setter´s
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public string Jornadas { get; set; }

        //Formatear la salida a Archivo de texto
        public override string ToString()
        {
            return _id + "|" + _nombre + "|" + _fechainicio.ToString("dd/MM/yyyy") + "|" + _fechatermino.ToString("dd/MM/yyyy");
        }
    }
}
