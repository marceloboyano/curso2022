
namespace FizzBuzz
{
    // La ejecución ya está definida en clase base. Lo único que necesitamos es definir la forma de la función Output
    // Para eso usamos el constructor
    public class FizzBuzzHttp : FizzBuzzBase
    {
        public FizzBuzzHttp() :
            base(EnviarPorHttp)
        {
        }

        public static void EnviarPorHttp(string text)
        {
            using (var httpClient = new HttpClient())
            {
                // La implementación va aca... El servidor se ejecuta en localhost:5199
            }
        }
    }
}
