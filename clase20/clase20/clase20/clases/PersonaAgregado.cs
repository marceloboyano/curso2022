using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase20.clases
{
    public partial class Persona
    {
          private string _apellido;

    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }

    }
        public partial int calcularEdad();
}
}
