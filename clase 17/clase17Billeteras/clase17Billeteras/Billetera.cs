using clase17Billeteras.version2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase17Billeteras
{
    public class Billetera:IBilletera
    {
        public int Billetede10 { get; set; }
        public int Billetede20 { get; set; }
        public int Billetede50 { get; set; }
        public int Billetede100 { get; set; }
        public int Billetede200 { get; set; }
        public int Billetede500 { get; set; }
        public int Billetede1000 { get; set; }

        public decimal Total()
        {
           
           
                var total=Billetede10 * 10m +
                       Billetede20 * 20m +
                       Billetede50 * 50m +
                       Billetede100 * 100m +
                       Billetede200 * 200m +
                       Billetede500 * 500m +
                        Billetede1000 * 1000m;
                return total;

          
        }

        public  IBilletera Combinar(IBilletera b)
        {
            var nueva = new Billetera();
            //combinamos
            nueva.Billetede10 = Billetede10 + b.Billetede10;
            nueva.Billetede20 = Billetede20 + b.Billetede20;
            nueva.Billetede50 = Billetede50 + b.Billetede50;
            nueva.Billetede100 = Billetede100 + b.Billetede100;
            nueva.Billetede200 = Billetede200 + b.Billetede200;
            nueva.Billetede500 = Billetede500 + b.Billetede500;
            nueva.Billetede1000 = Billetede1000 + b.Billetede1000;
            //vaciamos esta billetera
           Billetede10 =0;
             Billetede20=0;
            Billetede50 =0;
            Billetede100 =0;
            Billetede200 =0;
            Billetede500 =0;
            Billetede1000 = 0;
            //vaciamos esta billetera
             b.Billetede10=0;
            b.Billetede20=0;
            b.Billetede50=0;
            b.Billetede100=0;
            b.Billetede200=0;
            b.Billetede500=0;

            return nueva;
        }

      
    }
}
