﻿namespace FizzBuzz
{
    // La ejecución ya está definida en clase base. Lo único que necesitamos es definir la forma de la función Output
    // Para eso usamos el constructor
    public class FizzBuzzConsola : FizzBuzzBase
    {
        public FizzBuzzConsola() :
            base(Show)
        {
        }
        static void Show(string text)
        {
            Console.WriteLine(text);
        }

      //  Action<string> Output = Show; ya no se usa
    }
}
