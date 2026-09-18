public class Alumno
{
    public string Nombre { get; set; } = "";
    public int Legajo { get; private set; }
    public decimal Nota1 { get; private set; }
    public decimal Nota2 { get; private set; }
    
    public Alumno(string nombre, int legajo)
    {
        Nombre = nombre;
        Legajo = legajo;
    }

    public decimal Promedio()
    {
        return (Nota1 + Nota2) / 2;
    }
    
    public bool EstaAprobado()
    {
        return Promedio() >= 6;
    }
    
    public void SubirNota()
    {
        if (Nota1 < 10)
        {
            Nota1++;
        }

        if (Nota2 < 10)
        {
            Nota2++;
        }
    }
    
    public bool CargarNotas(decimal nota1, decimal nota2)
    {
        if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
        {
            return false;
        }

        Nota1 = nota1;
        Nota2 = nota2;

        return true;
    }

    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {Promedio()})";
    }
}