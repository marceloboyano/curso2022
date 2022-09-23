namespace introduccionMVC.Data.Entities
{
    public class Vehiculo:BaseEntity
    {
        public string Dominio { get; set; }
        public string NumeroChasis { get; set; }
        public string Propietario { get; set; }
        public string AnioFabricacion { get; set; }
       
    }
}
