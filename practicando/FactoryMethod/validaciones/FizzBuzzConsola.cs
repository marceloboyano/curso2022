namespace FizzBuzz
{
    // La ejecución ya está definida en clase base. Lo único que necesitamos es definir la forma de la función Output
    // Para eso usamos el constructor
    public class FizzBuzzConsola : FizzBuzzBase
    {
        public FizzBuzzConsola(int inferior, int superior) :
            base(Console.WriteLine)
        {
            this.Inferior = inferior;
            this.Superior = superior;
        }
    }
}
