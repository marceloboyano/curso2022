using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase18
{
    public interface IBebida
    {
        public decimal Volumen { get; set; }
        public bool  Gasificada { get; set; }
        public string Color { get; set; }
        public decimal Calorias { get; set; }
        public bool Alcoholica { get; set; }

    }
    public interface IBebidasAlcoholicas: IBebida
    {
      
        public decimal Graduacion { get; set; }
    }
    public interface ICerverza:IBebidasAlcoholicas
    {
        public int IBU { get; set; }
       
    }

}
