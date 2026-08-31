public class Alumno
{
    public string Nombre { get; set; } = "";
    public int Legajo { get; set; }
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }
    
    public Alumno(string nombre, int legajo, decimal nota1, decimal nota2) //constructor
        {
        Nombre = nombre;
        Legajo = legajo;
        Nota1 = nota1;
        Nota2 = nota2;
        }

    public decimal Promedio()
    {
        return (Nota1 + Nota2)  / 2;
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
    public override string ToString()
    {
        return $"{Legajo} - {Nombre} (promedio: {Promedio()})";
    }
    
}


// La clase alumno no solo tiene datos sino que le agrego los metodos (para que pueda hacer cosas) 