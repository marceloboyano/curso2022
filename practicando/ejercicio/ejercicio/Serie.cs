
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




