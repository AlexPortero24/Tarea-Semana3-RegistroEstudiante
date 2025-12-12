using System;  // Importa el espacio de nombres System, necesario para usar la consola y otras funciones básicas

// Definición de la clase Estudiante
class Estudiante
{
    // Atributos que representan la información básica del estudiante
    public int ID;                     // Identificador único del estudiante
    public string Nombres = "";        // Nombres del estudiante inicializados para evitar advertencias de null
    public string Apellidos = "";      // Apellidos del estudiante inicializados para evitar advertencias de null
    public string Direccion = "";      // Dirección del estudiante inicializada para evitar advertencias de null

    // Arreglo de 3 posiciones para almacenar los números de teléfono
    public string[] Telefonos = new string[3]; // Cada posición del arreglo guarda un número telefónico

    // Método para mostrar todos los datos del estudiante en la consola
    public void MostrarDatos()
    {
        Console.WriteLine("===== DATOS DEL ESTUDIANTE ====="); // Título de la sección de datos
        Console.WriteLine($"ID: {ID}");                     // Muestra el ID
        Console.WriteLine($"Nombres: {Nombres}");           // Muestra los nombres
        Console.WriteLine($"Apellidos: {Apellidos}");       // Muestra los apellidos
        Console.WriteLine($"Dirección: {Direccion}");       // Muestra la dirección
        Console.WriteLine("Teléfonos registrados:");       // Mensaje previo al listado de teléfonos

        // Recorre el arreglo de teléfonos usando un ciclo for
        for (int i = 0; i < Telefonos.Length; i++)
        {
            // Muestra cada teléfono indicando su posición (i+1 para que empiece desde 1)
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

// Clase principal del programa
class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Estudiante
        Estudiante est = new Estudiante();

        // Solicitar el ID y validar que sea un número válido
        int id;
        do
        {
            Console.Write("Ingrese el ID (número entero): ");
        } while (!int.TryParse(Console.ReadLine(), out id)); // Repite hasta que el usuario ingrese un número válido
        est.ID = id; // Asigna el ID al estudiante

        // Solicitar datos al usuario mediante la consola
        Console.Write("Ingrese los nombres: ");
        est.Nombres = Console.ReadLine() ?? ""; // Asigna un valor vacío si el usuario no ingresa nada

        Console.Write("Ingrese los apellidos: ");
        est.Apellidos = Console.ReadLine() ?? ""; // Asigna un valor vacío si el usuario no ingresa nada

        Console.Write("Ingrese la dirección: ");
        est.Direccion = Console.ReadLine() ?? ""; // Asigna un valor vacío si el usuario no ingresa nada

        // Ciclo para llenar el arreglo de teléfonos
        for (int i = 0; i < est.Telefonos.Length; i++)
        {
            Console.Write($"Ingrese el teléfono {i + 1}: ");
            est.Telefonos[i] = Console.ReadLine() ?? ""; // Asigna un valor vacío si el usuario no ingresa nada
        }

        // Mostrar todos los datos ingresados usando el método de la clase
        Console.WriteLine("\nRESULTADOS:");
        est.MostrarDatos();

        // Mensaje final para que el usuario pueda ver los resultados antes de cerrar
        Console.WriteLine("\nPresione ENTER para finalizar...");
        Console.ReadLine(); // Espera que el usuario presione ENTER antes de cerrar la consola
    }
}
