




using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Text.Json;

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

        public static async void EnviarPorHttp(string text)
        {
            
            
            using (var httpClient = new HttpClient())
            {
               
                var f = new FizzBuzz { FizzBuzzValue = text };
                //httpClient.BaseAddress = new Uri("http://localhost:5199/");
                var url = "http://localhost:5199/api/fizzbuzz";

                var jsonFormat = JsonConvert.SerializeObject(f);
           
                var content = new StringContent(jsonFormat, Encoding.UTF8, "application/json");

                try
                {
                    var response =  httpClient.PostAsync(url, content).GetAwaiter().GetResult();
                }
                catch
                {
                    Console.WriteLine("Error");
                }
                
            

            // La implementación va aca... El servidor se ejecuta en localhost:5199
             }
        }
    }
}
