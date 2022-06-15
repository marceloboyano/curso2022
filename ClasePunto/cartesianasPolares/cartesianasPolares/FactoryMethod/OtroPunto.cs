using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartesianasPolares.FactoryMethod
{
    public class OtroPunto
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        // No dejamos que el usuario externo pueda ver el constructor --> no queremos que construya el punto con otro método 
        // más que los que le proveemos nosotros --> esto quita posibilidades de error
        private OtroPunto() {}

        #region Factory Static Method
        public static OtroPunto CrearPuntoCartesiano(double x, double y)
        {
            var punto = new OtroPunto();

            punto.X = x;
            punto.Y = y;

            return punto;
        }

        public static OtroPunto CrearPuntoPolar(double rho, double theta)
        {
            var punto = new OtroPunto();

            punto.X = rho * Math.Cos(theta);
            punto.Y = rho * Math.Sin(theta);

            return punto;
        }
        #endregion

        public override string ToString()
        {
            return $"El punto está ubicado en el eje cartesiano en el punto x:{X} y:{Y}";
        }
    }
}
