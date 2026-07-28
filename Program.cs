using Sistema_de_Gestion_de_Biblioteca.Generales;
using Sistema_de_Gestion_de_Biblioteca.Models;

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
    Console.Write("Ingrese el ID de la venta: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Venta objVenta = Database.Ventas.Find(v => v.Id == id);

    if (objVenta != null)
    {
        Database.Ventas.Remove(objVenta);

        Database.GuardarVentas();

        Console.WriteLine("Venta eliminada correctamente.");
    }
    else
    {
        Console.WriteLine("Venta no encontrada.");
    }

    Console.ReadLine();
}

void ActualizarVenta()
{
    Console.Clear();
    Console.Write("Ingrese el ID de la venta: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Venta objVenta = Database.Ventas.Find(v => v.Id == id);

    if (objVenta != null)
    {
        Console.WriteLine("Libros registrados:");

        foreach (Libro libro in Database.Libros)
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo}");
        }

        Console.Write("Ingrese el ID del libro: ");
        int idLibro = Convert.ToInt32(Console.ReadLine());

        objVenta.Libro = Database.Libros.Find(l => l.Id == idLibro);

        Console.WriteLine("\nClientes registrados:");

        foreach (Cliente cliente in Database.Clientes)
        {
            Console.WriteLine($"{cliente.Id} - {cliente.Nombre} {cliente.Apellido}");
        }

        Console.Write("Ingrese el ID del cliente: ");
        int idCliente = Convert.ToInt32(Console.ReadLine());

        objVenta.Cliente1 = Database.Clientes.Find(c => c.Id == idCliente);

        Console.Write("Fecha: ");
        objVenta.FechaVenta = Convert.ToDateTime(Console.ReadLine());

        Console.Write("Total: ");
        objVenta.Total = Convert.ToDecimal(Console.ReadLine());

        Database.GuardarVentas();

        Console.WriteLine("Venta actualizada correctamente.");
    }
    else
    {
        Console.WriteLine("Venta no encontrada.");
    }

    Console.ReadLine();
}

void BuscarVenta()
{
    Console.Clear();
    Console.Write("Ingrese el ID de la venta: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Venta objVenta = Database.Ventas.Find(v => v.Id == id);

    if (objVenta != null)
    {
        Console.WriteLine("Venta encontrada:");
        Console.WriteLine("--------------------------------");
        objVenta.Imprimir();
    }
    else
    {
        Console.WriteLine("Venta no encontrada.");
    }

    Console.ReadLine();
}

void ListarVentas()
{
    Console.Clear();
    Console.WriteLine("******** VENTAS REGISTRADAS ********");

    foreach (Venta venta in Database.Ventas)
    {
        venta.Imprimir();
        Console.WriteLine("--------------------------------");
    }

    Console.ReadLine();
}

void crearVenta()
{
    Console.Clear();
    Console.Write("Ingrese el ID de la venta: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nLibros registrados:");

    foreach (Libro libro in Database.Libros)
    {
        Console.WriteLine($"{libro.Id} - {libro.Titulo}");
    }

    Console.Write("Ingrese el ID del libro: ");
    int idLibro = Convert.ToInt32(Console.ReadLine());

    Libro objLibro = Database.Libros.Find(l => l.Id == idLibro);

    Console.WriteLine("\nClientes registrados:");

    foreach (Cliente cliente in Database.Clientes)
    {
        Console.WriteLine($"{cliente.Id} - {cliente.Nombre} {cliente.Apellido}");
    }

    Console.Write("Ingrese el ID del cliente: ");
    int idCliente = Convert.ToInt32(Console.ReadLine());

    Cliente objCliente = Database.Clientes.Find(c => c.Id == idCliente);

    Console.Write("Ingrese la fecha (dd/mm/yyyy): ");
    DateTime fecha = Convert.ToDateTime(Console.ReadLine());

    Console.Write("Ingrese el total: ");
    decimal total = Convert.ToDecimal(Console.ReadLine());

    Venta venta = new Venta(id, objLibro, objCliente, fecha, total);

    Database.Ventas.Add(venta);

    Database.GuardarVentas();

    Console.WriteLine("Venta registrada correctamente.");

    Console.ReadLine();
}

void EliminarCliente()
{
    Console.Clear();
    Console.Write("Ingrese el ID del cliente: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Cliente objCliente = Database.Clientes.Find(c => c.Id == id);

    if (objCliente != null)
    {
        Database.Clientes.Remove(objCliente);
        Database.GuardarClientes();

        Console.WriteLine("Cliente eliminado correctamente.");
    }
    else
    {
        Console.WriteLine("Cliente no encontrado.");
    }

    Console.ReadLine();
}

void ActualizarCliente()
{
    Console.Clear();
    Console.Write("Ingrese el ID del cliente: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Cliente objCliente = Database.Clientes.Find(c => c.Id == id);

    if (objCliente != null)
    {
        Console.Write("Nombre: ");
        objCliente.Nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        objCliente.Apellido = Console.ReadLine();

        Console.Write("Teléfono: ");
        objCliente.Telefono = Console.ReadLine();

        Console.Write("Cédula: ");
        objCliente.Cedula = Console.ReadLine();

        Database.GuardarClientes();

        Console.WriteLine("Cliente actualizado correctamente.");
    }
    else
    {
        Console.WriteLine("Cliente no encontrado.");
    }

    Console.ReadLine();
}

void BuscarCliente()
{
    Console.Clear();
    Console.Write("Ingrese el ID del cliente: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Cliente objCliente = Database.Clientes.Find(c => c.Id == id);

    if (objCliente != null)
    {
        Console.WriteLine("Cliente encontrado:");
        Console.WriteLine("--------------------------------");
        objCliente.Imprimir();
    }
    else
    {
        Console.WriteLine("Cliente no encontrado.");
    }

    Console.ReadLine();
}

void ListarClientes()
{
    Console.Clear();
    Console.WriteLine("******** CLIENTES REGISTRADOS ********");

    foreach (Cliente cliente in Database.Clientes)
    {
        cliente.Imprimir();
        Console.WriteLine("--------------------------------");
    }

    Console.ReadLine();
}

void crearCliente()
{
    Console.Clear();
    Console.Write("Ingrese el ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Ingrese el apellido: ");
    string apellido = Console.ReadLine();

    Console.Write("Ingrese el teléfono: ");
    string telefono = Console.ReadLine();

    Console.Write("Ingrese la cédula: ");
    string cedula = Console.ReadLine();

    Cliente cliente = new Cliente(id, nombre, apellido, telefono, cedula);

    Database.Clientes.Add(cliente);
    Database.GuardarClientes();

    Console.WriteLine("Cliente registrado correctamente.");
    Console.ReadLine();

}

void EliminarLibro()
{
    Console.Clear();
    Console.Write("Ingrese el ID del libro: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Libro objLibro = Database.Libros.Find(l => l.Id == id);

    if (objLibro != null)
    {
        Database.Libros.Remove(objLibro);

        Database.GuardarLibros();

        Console.WriteLine("Libro eliminado correctamente.");
    }
    else
    {
        Console.WriteLine("Libro no encontrado.");
    }

    Console.ReadLine();
}

void ActualizarLibro()
{
    Console.Clear();
    Console.Write("Ingrese el ID del libro: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Libro objLibro = Database.Libros.Find(l => l.Id == id);

    if (objLibro != null)
    {
        Console.Write("Título: ");
        objLibro.Titulo = Console.ReadLine();

        Console.Write("Género: ");
        objLibro.Genero = Console.ReadLine();

        Console.Write("Año de publicación: ");
        objLibro.AnioPublicacion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Disponible (true/false): ");
        objLibro.Disponible = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Precio: ");
        objLibro.Precio = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("\nAutores registrados:");

        foreach (Autor autor in Database.Autores)
        {
            Console.WriteLine($"{autor.Id} - {autor.Nombre}");
        }

        Console.Write("Ingrese el ID del autor: ");
        int idAutor = Convert.ToInt32(Console.ReadLine());

        Autor objAutor = Database.Autores.Find(a => a.Id == idAutor);

        if (objAutor != null)
        {
            objLibro.Autor = objAutor;
        }

        Database.GuardarLibros();

        Console.WriteLine("Libro actualizado correctamente.");
    }
    else
    {
        Console.WriteLine("Libro no encontrado.");
    }

    Console.ReadLine();
}

void BuscarLibro()
{
    Console.Clear();
    Console.Write("Ingrese el ID del libro: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Libro objLibro = Database.Libros.Find(l => l.Id == id);

    if (objLibro != null)
    {
        Console.WriteLine("Libro encontrado:");
        Console.WriteLine("----------------------------");
        objLibro.Imprimir();
    }
    else
    {
        Console.WriteLine("Libro no encontrado.");
    }

    Console.ReadLine();
}

void Listarlibros()
{
    Console.Clear();
    Console.WriteLine("******** Libros Registrados ********");

    foreach (Libro libro in Database.Libros)
    {
        libro.Imprimir();
        Console.WriteLine("--------------------------------");
    }

    Console.ReadLine();

}

void crearLibro()
{
    Console.Clear();
    Console.Write("Ingrese el ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el título: ");
    string titulo = Console.ReadLine();

    Console.Write("Ingrese el género: ");
    string genero = Console.ReadLine();

    Console.Write("Ingrese el año de publicación: ");
    int anio = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el precio: ");
    decimal precio = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Disponible (true/false): ");
    bool disponible = Convert.ToBoolean(Console.ReadLine());

    Console.WriteLine("\nAutores registrados:");

    foreach (Autor autor in Database.Autores)
    {
        Console.WriteLine($"{autor.Id} - {autor.Nombre}");
    }

    Console.Write("Ingrese el ID del autor: ");
    int idAutor = Convert.ToInt32(Console.ReadLine());

    Autor objAutor = Database.Autores.Find(a => a.Id == idAutor);

    Libro libro = new Libro(id, titulo, genero, anio, disponible, precio, objAutor);

    Database.Libros.Add(libro);
    Database.GuardarLibros();

    Console.WriteLine("Libro registrado correctamente.");
    Console.ReadLine();
}

void EliminarAutor()
{
    Console.Clear();
    Console.Write("Ingrese el ID del autor: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Autor objAutor = Database.Autores.Find(a => a.Id == id);

    if (objAutor != null)
    {
        Database.Autores.Remove(objAutor);
        Database.GuardarAutores();

        Console.WriteLine("Autor eliminado correctamente.");
    }
    else
    {
        Console.WriteLine("Autor no encontrado.");
    }

    Console.ReadLine();
}

void ActualizarAutor()
{
    Console.Clear();
    Console.Write("Ingrese el ID del autor: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Autor objAutor = Database.Autores.Find(a => a.Id == id);

    if (objAutor != null)
    {
        Console.Write("Nuevo nombre: ");
        objAutor.Nombre = Console.ReadLine();

        Console.Write("Nuevo género literario: ");
        objAutor.GeneroLiterario = Console.ReadLine();

        Console.Write("Cantidad de libros: ");
        objAutor.CantidadLibros = Convert.ToInt32(Console.ReadLine());

        Console.Write("Correo: ");
        objAutor.Correo = Console.ReadLine();

        Database.GuardarAutores();

        Console.WriteLine("Autor actualizado correctamente.");
    }
    else
    {
        Console.WriteLine("Autor no encontrado.");
    }

    Console.ReadLine();
}

void BuscarAutor()
{
    Console.Clear();
    Console.Write("Ingrese el ID del autor: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Autor objAutor = Database.Autores.Find(a => a.Id == id);

    if (objAutor != null)
    {
        Console.WriteLine("Autor encontrado:");
        Console.WriteLine("--------------------------------");
        objAutor.Imprimir();
    }
    else
    {
        Console.WriteLine("Autor no encontrado.");
    }

    Console.ReadLine();
}

void listarAutores()
{
    Console.Clear();
    Console.WriteLine("************Autores Registrados************");

    foreach (Autor autor in Database.Autores)
    {
        autor.Imprimir();
        Console.WriteLine("--------------------------------");
    }

    Console.ReadLine();

}

void crearAutor()
{
    Console.Clear();

    Console.Write("Ingrese el ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Ingrese el género literario: ");
    string genero = Console.ReadLine();

    Console.Write("Ingrese la cantidad de libros: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el correo: ");
    string correo = Console.ReadLine();

    Autor autor = new Autor(id, nombre, genero, cantidad, correo);

    Database.Autores.Add(autor);
    Database.GuardarAutores();

    Console.WriteLine("Autor registrado correctamente.");
    Console.ReadLine();
}