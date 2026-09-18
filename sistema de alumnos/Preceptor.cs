public class Preceptor : Persona
{
    public string Turno { get; set; } = "";

    public Preceptor(string nombre, int documento, string turno)
        : base(nombre, documento)
    {
        Turno = turno;
    }

    public override string Presentarse()
    {
        return $"Hola, soy {Nombre} y soy preceptor del turno {Turno}.";
    }
}