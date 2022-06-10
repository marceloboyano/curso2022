
using clase14;

var personas = new List<Persona>();
for (int i = 0; i < 10; i++)
{
    var p = new Persona();
    personas.Add(p);
}
Persona.saludar();