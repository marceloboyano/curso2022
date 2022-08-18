using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_29_EF_codeFirst.Modelo
{
    internal class Sucursal:EntidadBase
    {
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        //public Domicilio Domicilio { get; set; }
        public List<Deposito> Depositos { get; set; }

    }
}
