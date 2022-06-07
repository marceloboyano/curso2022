using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulamiento.Modelo
{
    internal class Auto
    {
        //Campos
        private string _tipoDeMotor;
        private string _anioDeFabicacion;
        
        public string TipoDeMotor
        {
            get { return _tipoDeMotor; }
            set { if (value == null || value == "")
                {
                    _tipoDeMotor = "Diesel";
                }
                else
                {
                    _tipoDeMotor = value;
                }
                 
        }
        //propiedades auto implementadas
        public bool EstaEncendido { get; set; }
        public int AnioDeFabricacion { get; set; }
        public string Marca { get; set; }
    }
}
