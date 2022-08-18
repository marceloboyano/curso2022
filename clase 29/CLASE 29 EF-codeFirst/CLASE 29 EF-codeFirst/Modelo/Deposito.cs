using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_29_EF_codeFirst.Modelo
{
    public class Deposito: EntidadBase
    {
        public string Descripcion { get; set; }
        //public Domicilio Domicilio { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
