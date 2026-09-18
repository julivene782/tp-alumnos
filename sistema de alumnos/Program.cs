Alumno alumno1 = new Alumno("Juan", 1234);
Alumno alumno2 = new Alumno("Sofia", 5678);
Alumno alumno3 = new Alumno("Julia", 1564);
Alumno alumno4 = new Alumno("Pilar", 8978);

if (!alumno1.CargarNotas(8.5m, 7.5m))
{
    Console.WriteLine("Las notas del alumno 1 son inválidas.");
}

if (!alumno2.CargarNotas(9m, 8m))
{
    Console.WriteLine("Las notas del alumno 2 son inválidas.");
}

if (!alumno3.CargarNotas(5.7m, 7m))
{
    Console.WriteLine("Las notas del alumno 3 son inválidas.");
}

if (!alumno4.CargarNotas(9m, 3m))
{
    Console.WriteLine("Las notas del alumno 4 son inválidas.");
}

Console.WriteLine($"Alumno 1: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
Console.WriteLine($"Alumno 2: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

alumno1.Nombre = "Pedro";

Console.WriteLine($"Nuevo nombre del alumno 1: {alumno1.Nombre}");
Console.WriteLine($"Nombre del alumno 2: {alumno2.Nombre}");

Console.WriteLine($"Promedio de {alumno1.Nombre}: {alumno1.Promedio()}");
Console.WriteLine($"Promedio de {alumno2.Nombre}: {alumno2.Promedio()}");
Console.WriteLine($"Promedio de {alumno3.Nombre}: {alumno3.Promedio()}");
Console.WriteLine($"Promedio de {alumno4.Nombre}: {alumno4.Promedio()}");

Console.WriteLine($"{alumno1.Nombre} aprobado: {alumno1.EstaAprobado()}");
Console.WriteLine($"{alumno2.Nombre} aprobado: {alumno2.EstaAprobado()}");
Console.WriteLine($"{alumno3.Nombre} aprobado: {alumno3.EstaAprobado()}");
Console.WriteLine($"{alumno4.Nombre} aprobado: {alumno4.EstaAprobado()}");

Console.WriteLine(alumno1);
Console.WriteLine(alumno2);
Console.WriteLine(alumno3);
Console.WriteLine(alumno4);