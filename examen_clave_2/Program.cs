using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Programa de Canciones");
            Console.WriteLine("2. Programa de Alumnos");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");


            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    EjecutarProgramaCanciones();
                    break;
                case 2:
                    EjecutarProgramaAlumnos();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void EjecutarProgramaCanciones()
    {
        int numCanciones = 1; // Puedes cambiar este valor para ajustarlo al número de canciones que deseas almacenar.
        string[] artistas = new string[numCanciones];
        string[] titulos = new string[numCanciones];
        int[] duraciones = new int[numCanciones];
        int[] tamanios = new int[numCanciones];

        Console.WriteLine("--------Programa de canciones------------");
        Console.WriteLine("Ingrese los datos de las canciones:");

        for (int i = 0; i < numCanciones; i++)
        {
            Console.WriteLine("Canción #" + (i + 1));
            Console.Write("Artista: ");
            artistas[i] = Console.ReadLine();

            Console.Write("Título: ");
            titulos[i] = Console.ReadLine();

            Console.Write("Duración (en segundos): ");
            duraciones[i] = int.Parse(Console.ReadLine());

            Console.Write("Tamaño del fichero (en KB): ");
            tamanios[i] = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        Console.WriteLine("Canciones almacenadas:");

        for (int i = 0; i < numCanciones; i++)
        {
            Console.WriteLine("Canción #" + (i + 1));
            Console.WriteLine("Artista: " + artistas[i]);
            Console.WriteLine("Título: " + titulos[i]);
            Console.WriteLine("Duración (segundos): " + duraciones[i]);
            Console.WriteLine("Tamaño del fichero (KB): " + tamanios[i]);
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para volver al Menú Principal.");
            Console.ReadKey();
           
        } 
    }

    
    
 

    // Definimos las variables para almacenar los datos de un alumno
    struct Alumno
    {
        public int Codigo;
        public string Nombre;
        public DateTime FechaNacimiento;
        public int Grado;
        public int AnioRegistro;
    }

    static Alumno[] alumnos = new Alumno[100]; // Arreglo para almacenar los alumnos
    static int totalAlumnos = 0; // Contador para llevar el control del número de alumnos

    static void EjecutarProgramaAlumnos()
    {
        while (true)
        {
            Console.WriteLine("-------Programa de Alumnos-------");
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar un alumno");
            Console.WriteLine("2. Mostrar listado de alumnos");
            Console.WriteLine("3. Buscar alumno por código");
            Console.WriteLine("4. Editar información de un alumno");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ") ;

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarAlumno();
                    break;
                case 2:
                    MostrarAlumnos();
                    break;
                case 3:
                    BuscarAlumnoPorCodigo();
                    break;
                case 4:
                    EditarAlumnoPorCodigo();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }
    }

    static void AgregarAlumno()
    {
        Console.Write("Ingrese el código del alumno: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el nombre del alumno: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la fecha de nacimiento (YYYY-MM-DD): ");
        DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

        Console.Write("Ingrese el grado del alumno: ");
        int grado = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el año de registro: ");
        int anioRegistro = Convert.ToInt32(Console.ReadLine());

        alumnos[totalAlumnos].Codigo = codigo;
        alumnos[totalAlumnos].Nombre = nombre;
        alumnos[totalAlumnos].FechaNacimiento = fechaNacimiento;
        alumnos[totalAlumnos].Grado = grado;
        alumnos[totalAlumnos].AnioRegistro = anioRegistro;

        totalAlumnos++;
    }

    static void MostrarAlumnos()
    {
        Console.WriteLine("Listado de Alumnos:");
        Console.WriteLine("Código\t| Nombre\t\t| Fecha Nacimiento\t| Grado\t| Año de Registro");
        Console.WriteLine("---------------------------------------------------------------------");

        for (int i = 0; i < totalAlumnos; i++)
        {
            Console.WriteLine($"{alumnos[i].Codigo}\t| {alumnos[i].Nombre,-20}\t| {alumnos[i].FechaNacimiento,-20:yyyy-MM-dd}\t| {alumnos[i].Grado}\t| {alumnos[i].AnioRegistro} " );
        }
    }


    static void BuscarAlumnoPorCodigo()
    {
        Console.Write("Ingrese el código del alumno a buscar: ");
        int codigoBuscado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Resultado de la búsqueda:");
        Console.WriteLine("Código\t| Nombre\t\t| Fecha Nacimiento\t| Grado\t| Año de Registro");
        Console.WriteLine("-----------------------------------------------------------------------");

        for (int i = 0; i < totalAlumnos; i++)
        {
            if (alumnos[i].Codigo == codigoBuscado)
            {
                Console.WriteLine($"{alumnos[i].Codigo}\t| {alumnos[i].Nombre,-20}\t| {alumnos[i].FechaNacimiento,-20:yyyy-MM-dd}\t| {alumnos[i].Grado}\t| {alumnos[i].AnioRegistro}");
                return;
            }
        }

        Console.WriteLine($"No se encontró ningún alumno con el código {codigoBuscado}.");
    }


    static void EditarAlumnoPorCodigo()
    {
        Console.Write("Ingrese el código del alumno a editar: ");
        int codigoBuscado = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < totalAlumnos; i++)
        {
            if (alumnos[i].Codigo == codigoBuscado)
            {
                Console.WriteLine("Información actual del alumno:");
                Console.WriteLine("Código\t| Nombre\t\t| Fecha Nacimiento\t| Grado\t| Año de Registro");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine($"{alumnos[i].Codigo}\t| {alumnos[i].Nombre,-20}\t| {alumnos[i].FechaNacimiento,-20:yyyy-MM-dd}\t| {alumnos[i].Grado}\t| {alumnos[i].AnioRegistro}");

                Console.WriteLine("Ingrese la nueva información del alumno:");

                Console.Write("Nuevo nombre: ");
                alumnos[i].Nombre = Console.ReadLine();

                Console.Write("Nueva fecha de nacimiento (YYYY-MM-DD): ");
                alumnos[i].FechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.Write("Nuevo grado: ");
                alumnos[i].Grado = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nuevo año de registro: ");
                alumnos[i].AnioRegistro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Información actualizada exitosamente.");
                return;
            }
        }

        Console.WriteLine($"No se encontró ningún alumno con el código {codigoBuscado}.");
        Console.ReadKey();
        Console.WriteLine("Presione cualquier tecla para volver al Menú Principal.");
    }
}
    

