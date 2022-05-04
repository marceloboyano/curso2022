

 abstract class serie
{
    private string titulo;
    private int numeroTemporadas = 3;
    private bool entregado = false;
    private string genero;
    private string creador;

    public void set(string titulo, int numeroTemporadas, string genero, string creador)
    {
        this.titulo = titulo;
        this.numeroTemporadas = numeroTemporadas;  
        this.genero = genero;  
        this.creador = creador; 
    }
    public string get()
    {
        this.titulo = titulo;
        this.numeroTemporadas = numeroTemporadas;
        this.genero = genero;
        this.creador = creador;
    }
}