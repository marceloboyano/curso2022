using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase18
{
    public class Cerveza : ICerverza
    {
        public decimal Volumen { get; set; }
        public bool Gasificada { get ; set ; }
        public string Color { get ; set ; }
        public decimal Calorias { get ; set ; }
        public bool Alcoholica { get ; set ; }
        public int IBU { get; set; }
        public decimal Graduacion { get ; set ; }
    }
}
