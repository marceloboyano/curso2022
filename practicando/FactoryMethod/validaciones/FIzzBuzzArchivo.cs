namespace FizzBuzz
{
    public class FizzBuzzArchivo : FizzBuzzBase
    {
        public FizzBuzzArchivo()
            : base(EscribirArchivo)
        {   
        }

        private static void EscribirArchivo(string text) 
        {
            using (Stream fs = new FileStream("./test.txt", FileMode.Append, FileAccess.Write))
            {

                using (StreamWriter sw = new StreamWriter(fs))
                {

                    sw.WriteLine(text);
                }
            }
        }
    }
}
