namespace clase17Billeteras.version2
{
    public interface IBilletera
    {
        int Billetede10 { get; set; }
        int Billetede100 { get; set; }
        int Billetede1000 { get; set; }
        int Billetede20 { get; set; }
        int Billetede200 { get; set; }
        int Billetede50 { get; set; }
        int Billetede500 { get; set; }

        IBilletera Combinar(IBilletera b);
        decimal Total();
    }
}