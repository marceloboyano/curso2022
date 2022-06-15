using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartesianasPolares.Modelos
{
    public class PuntoPolar:Punto
    {
        public PuntoPolar(double radio, double distancia) : base(radio, distancia)
        {



        }
        public PuntoPolar()
        {
            
        }
        public override string ToString() => $"Este es un punto Polar y sus valores son: {this.X} radio, {this.Y} distancia";
    }
}
