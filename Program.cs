using Sistema_de_Gestion_de_Biblioteca.Generales;

Database.CargarDatos();
int opcion = 0;
do
{
    Console.Clear();
    Console.WriteLine("**************** Welcome to The Whispering Quill****************");
    Console.WriteLine("Menú de Opciones:");

    Console.WriteLine("1.- Crear Autor");
    Console.WriteLine("2.- Listar Autores");
    Console.WriteLine("3.- Buscar Autor");
    Console.WriteLine("4.- Actualizar Autor");
    Console.WriteLine("5.- Eliminar Autor");

    Console.WriteLine("6.- Crear libro");
    Console.WriteLine("7.- Listar Libros");
    Console.WriteLine("8.- Buscar Libro");
    Console.WriteLine("9.- Actualizar Libros");
    Console.WriteLine("10.- Eliminar Libro");

    Console.WriteLine("11.- Crear Cliente");
    Console.WriteLine("12.- Listar Clientes");
    Console.WriteLine("13.- Buscar Cliente");
    Console.WriteLine("14.- Actualizar Cliente");
    Console.WriteLine("15.- Eliminar Cliente");

    Console.WriteLine("16.- Crear Venta");
    Console.WriteLine("17.- Listar Ventas");
    Console.WriteLine("18.- Buscar Venta");
    Console.WriteLine("19.- Actualizar Venta");
    Console.WriteLine("20.- Eliminar Venta");

    Console.WriteLine("21.- Salir");
    Console.WriteLine("");
    Console.Write("Ingrese una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            crearAutor();
            break;
        case 2:
            listarAutores();
            break;
        case 3:
            BuscarAutor();
            break;

        case 4:
            ActualizarAutor();
            break;

        case 5:
            EliminarAutor();
            break;

        case 6:
            crearLibro();
            break;

        case 7:
            Listarlibros();
            break;

        case 8:
            BuscarLibro();
            break;

        case 9:
            ActualizarLibro();
            break;

        case 10:
            EliminarLibro();
            break;

        case 11:
            crearCliente();
            break;

        case 12:
            ListarClientes();
            break;

        case 13:
            BuscarCliente();
            break;

        case 14:
            ActualizarCliente();
            break;

        case 15:
            EliminarCliente();
            break;

        case 16:
            crearVenta();
            break;

        case 17:
            ListarVentas();
            break;

        case 18:
            BuscarVenta();
            break;

        case 19:
            ActualizarVenta();
            break;

        case 20:
            EliminarVenta();
            break;

        case 21:
            Console.WriteLine("Saliendo...");
            break;

    }
} while (opcion != 21);

void EliminarVenta()
{
    Console.Clear();
}

void ActualizarVenta()
{
    Console.Clear();
}

void BuscarVenta()
{
    Console.Clear();
}

void ListarVentas()
{
    Console.Clear();
}

void crearVenta()
{
    Console.Clear();
}

void EliminarCliente()
{
    Console.Clear();
}

void ActualizarCliente()
{
    Console.Clear();
}

void BuscarCliente()
{
    Console.Clear();
}

void ListarClientes()
{
    Console.Clear();
}

void crearCliente()
{
    Console.Clear();
}

void EliminarLibro()
{
    Console.Clear();
}

void ActualizarLibro()
{
    Console.Clear();
}

void BuscarLibro()
{
    Console.Clear();
}

void Listarlibros()
{
    Console.Clear();
}

void crearLibro()
{
    Console.Clear();
}

void EliminarAutor()
{
    Console.Clear();
}

void ActualizarAutor()
{
    Console.Clear();
}

void BuscarAutor()
{
    Console.Clear();
}

void listarAutores()
{
    Console.Clear();
}

void crearAutor()
{
    Console.Clear();
}