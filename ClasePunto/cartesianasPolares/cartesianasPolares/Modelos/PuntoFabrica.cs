using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartesianasPolares.Modelos
{
    public class PuntoFabrica<T> where T : IPunto, new()
    {
           
        
            public static T ObtenerInstancia(double x, double y)
            {
                var puntoInstance = new T();
                puntoInstance.setPunto(x, y);

                return puntoInstance;
            }

       

    }
}
