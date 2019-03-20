using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidad_lll
{
   class persona
    {
        protected int _id;
        protected string _nombre;
        protected string _apellidos;
        protected string _domicilio;
        protected string _email;
        protected string _password;

        public persona()
        {
            _nombre = "Jesus";
            _apellidos = "jimenez";
        }

        public persona(string nombre, string apellidos)
        {
            _nombre = nombre;
            _apellidos = apellidos;
        }

        //Metodos Getter´s y Setter´s
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                    _nombre = value;
            }
        }

        public string apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                if (value.legth >= 3 && value.legth <= 30)
                    _apelliodos = value;

            }
        }