Alumno alumno1 = new Alumno("Juan", 1234, 8.5m, 7.5m);
Alumno alumno2 = new Alumno("Sofia", 5678, 9m, 8m);

Console.WriteLine($"Alumno 1: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
Console.WriteLine($"Alumno 2: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

alumno1.Nombre = "Pedro";

Console.WriteLine($"Nuevo nombre del alumno 1: {alumno1.Nombre}");
Console.WriteLine($"Nombre del alumno 2: {alumno2.Nombre}");

Alumno alumno3 = new Alumno("Julia", 1564, 5.7m, 7m);
Alumno alumno4 = new Alumno("Pilar", 8978, 9m, 3m);

Console.WriteLine($"Promedio de {alumno1.Nombre}: {alumno1.Promedio()}");
Console.WriteLine($"Promedio de {alumno2.Nombre}: {alumno2.Promedio()}");
Console.WriteLine($"{alumno1.Nombre} aprobado: {alumno1.EstaAprobado()}");
Console.WriteLine($"{alumno2.Nombre} aprobado: {alumno2.EstaAprobado()}");