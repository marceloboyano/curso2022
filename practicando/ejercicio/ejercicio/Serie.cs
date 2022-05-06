/*Crearemos una clase llamada Serie con las siguientes caracteristicas: Sus atributos son titulo, numero de temporadas, entregado, genero y creador.
 * Por defecto, el numero de temporadas es de 3 temporadas y entregado false.
 * El resto de atributos serán valores por defecto según el tipo de atributo. 
 * Los constructores que se implementaran serán:
 * Un constructor por defecto.
 * Un constructor con el titulo y creador.
 * El resto por defecto. Un constructor con todos los atributos, excepto de entregado.
 * Los metodos que se implementara serán:
 * Métodos get de todos los atributos, excepto de entregado.
 * Metodos set de todos los atributos, excepto entregado. Sobreescribe los metodos toString. */

serie walkingdead = new serie("peterpan",4,"accion","travolta");
Console.WriteLine(walkingdead.ToString());
Console.WriteLine("titulo: " + walkingdead.Titulo + " numero de temporadas: " +walkingdead.NumeroTemporadas+ " genero: "+walkingdead.Genero+" creador: "+walkingdead.Creador);
public class serie
{
    private string titulo;
    private int numeroTemporadas = 3;
    private bool entregado;
    private string genero;
    private string creador;

    public serie(string titulo, int numeroTemporadas, string genero, string creador)
    {
        this.titulo = titulo;
        this.numeroTemporadas = numeroTemporadas;
        entregado = false;
        this.genero = genero;
        this.creador = creador;


    }
    public serie(string titulo, string creador)
    {
        this.titulo = titulo;
        this.creador = creador;

    }

    public serie()
    {
    }

    public string Titulo { get => titulo; set => titulo = value; }
    public int NumeroTemporadas { get => numeroTemporadas; set => numeroTemporadas = value; }
    public string Genero { get => genero; set => genero = value; }
    public string Creador { get => creador; set => creador = value; }

    public override string ToString() => $"titulo: {titulo} numero de temporadas: {numeroTemporadas}  genero: {genero} creador: {creador}";



}




