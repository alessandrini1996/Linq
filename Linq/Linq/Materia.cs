using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Materia
    {
        /// <summary>
        /// Nombre de la materia.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Año de la carrera en el que se dicta la materia.
        /// </summary>
        public short Anio { get; set; }

        /// <summary>
        /// Profesor que dicta la materia.
        /// </summary>
        public Profesor Profesor { get; set; }
    }

}
