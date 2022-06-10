using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia.Colegio
{
    public class Profesor: Persona
    {
        public int CantidadAlumnos{ get; set; }
        public string Materias { get; set; }
    }
    
}
