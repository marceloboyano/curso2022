using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase14
{
   public class Baraja
    {

        public List<Carta> Naipes = new List<Carta>();
        public List<Carta> Monton = new List<Carta>();

        public void Barajar()
        {
            var random = new Random();
            int n = Naipes.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var carta = Naipes[k];
                Naipes[k] = Naipes[n];
                Naipes[n] = carta;
            }
           
        }
        public Carta SiguienteCarta()
        {
            if (Naipes.Count == 0)
            {
                Console.WriteLine("   No quedan mas cartas en la baraja\n");
                return null;
            }
            var cartaDevuelta = Naipes[Naipes.Count - 1];
            Monton.Add(cartaDevuelta);
            Naipes.Remove(Naipes[Naipes.Count - 1]);
            Console.WriteLine("   Se ha tomado la siguiente carta de la Baraja: " + cartaDevuelta.Numero.ToString("00") + " de " + cartaDevuelta.Palo);
            return cartaDevuelta;
        }

        public void CartasDisponibles()
        {
          
          Console.WriteLine($"   Quedan {Naipes.Count} en la baraja\n");

        }
        
        public int DarCartas(int cantidad)
        {
            if(Naipes.Count < cantidad )
            {
                Console.WriteLine("   Estas pidiendo mas cartas de las que hay en la baraja\n");
                return 0;
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                   SiguienteCarta();
                }
                return cantidad;
            }
          
        }
        
        public void CartasMonton()
        {
            if (Monton.Count == 0)
            {
                Console.WriteLine("   No has sacado ninguna Carta");
            }
            else
            {
                foreach (var carta in Monton)
                {
                    Console.WriteLine($"   {carta.Numero.ToString("00")}  {carta.Palo}  ");
                }

                           
            }
        }
        public void MostrarBaraja()
        {
            foreach (var carta in Naipes)
            {
                Console.WriteLine($"   {carta.Numero.ToString("00")}  {carta.Palo}  ");
            }
        }
        

    }
}
