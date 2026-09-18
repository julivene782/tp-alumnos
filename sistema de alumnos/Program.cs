List<Alumno> alumnos = new List<Alumno>();

int opcion;

do
{
    Console.WriteLine();
    Console.WriteLine("----- MENÚ -----");
    Console.WriteLine("1 - Agregar alumno");
    Console.WriteLine("2 - Listar alumnos");
    Console.WriteLine("3 - Buscar alumno por legajo");
    Console.WriteLine("4 - Mostrar promedio general");
    Console.WriteLine("5 - Mostrar cantidad de alumnos aprobados");
    Console.WriteLine("6 - Salir");
    Console.Write("Ingrese una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Opción inválida.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Ingrese el documento: ");
            int documento = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el legajo: ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 1: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            Alumno nuevoAlumno = new Alumno(nombre, documento, legajo);

            if (nuevoAlumno.CargarNotas(nota1, nota2))
            {
                alumnos.Add(nuevoAlumno);
                Console.WriteLine("Alumno agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Las notas son inválidas.");
            }

            break;

        case 2:
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados.");
            }
            else
            {
                foreach (Alumno alumno in alumnos)
                {
                    Console.WriteLine(alumno);
                }
            }

            break;

        case 3:
            Console.Write("Ingrese el legajo que desea buscar: ");
            int legajoBuscado = int.Parse(Console.ReadLine());

            Alumno? alumnoEncontrado =
                alumnos.FirstOrDefault(a => a.Legajo == legajoBuscado);

            if (alumnoEncontrado == null)
            {
                Console.WriteLine("No existe un alumno con ese legajo.");
            }
            else
            {
                Console.WriteLine(alumnoEncontrado);
            }

            break;

        case 4:
            if (alumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargados.");
            }
            else
            {
                decimal promedioGeneral =
                    alumnos.Average(a => a.Promedio());

                Console.WriteLine($"Promedio general del curso: {promedioGeneral}");
            }

            break;

        case 5:
            int cantidadAprobados =
                alumnos.Count(a => a.EstaAprobado());

            Console.WriteLine($"Cantidad de alumnos aprobados: {cantidadAprobados}");

            break;

        case 6:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("La opción ingresada no existe.");
            break;
    }

} while (opcion != 6);