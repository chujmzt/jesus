using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using unidad_lll.vista;
using System.Windows.Forms;


namespace unidad_lll
{
    static class Program
    {
        public static FormaCampeonato formaCampeonato = null;
        public static Principal formaPrincipal = null;
        public static FormaJornada formaJornada = null;

        ///<summary>
        /// the main entry point for the aplication
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formaPrincipal = new Principal();
            formaCampeonato = new FormaCampeonato();
           jornada = new FormaJornada();

            Application.Run(formaPrincipal);


        }
    }
}
  
    
       