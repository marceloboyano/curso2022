using clase18.Models;

var alumno = new Alumno()
{
    Nombre = "Joaquin",
    Apellido = "Mateos",
    DNI = "1232131",
    Legajo = 12312,

};

var docente = new Docente()
{
    Nombre = "Eze",
    Apellido = "Erchecoin",
    DNI = "1232112131",
    Horas = 123,

};

var listado = new List<IPersona>();
listado.Add(docente);
listado.Add(alumno);

var nuevoListado = ObtenerPersonasByNombre(listado, "Eze");
Console.WriteLine(nuevoListado.Count);

  string ObtenerDatos(IPersona persona)
{
    var datos = persona.Nombre + " " + persona.Apellido;
    return datos;
}

List<IPersona> ObtenerPersonasByNombre (List<IPersona> personas, string nombre)
{
    var nuevaLista = new List<IPersona>();
    foreach (var p in personas)
    {
        if(p.Nombre == nombre)
        {
            nuevaLista.Add(p);
        }
    }
    return nuevaLista;
}



Console.WriteLine(ObtenerDatos(alumno));