using Sistema_de_Gestion_de_Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Biblioteca.Generales
{
    public class Database
    {
        private static readonly string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");
        private static readonly string rutaArchivoAutores = Path.Combine(rutaCarpeta, "Autores.json");
        private static readonly string rutaArchivoLibros = Path.Combine(rutaCarpeta, "Libros.json");
        private static readonly string rutaArchivoClientes = Path.Combine(rutaCarpeta, "Clientes.json");
        private static readonly string rutaArchivoVentas = Path.Combine(rutaCarpeta, "Ventas.json");

        public static List<Autor> Autores { get; set; } = new List<Autor>();
        public static List<Libro> Libros { get; set; } = new List<Libro>();
        public static List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public static List<Venta> Ventas { get; set; } = new List<Venta>();

        public static void CargarDatos()
        {
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            Autores = ArchivoJson.Cargar<Autor>(rutaArchivoAutores);
            Libros = ArchivoJson.Cargar<Libro>(rutaArchivoLibros);
            Clientes = ArchivoJson.Cargar<Cliente>(rutaArchivoClientes);
            Ventas = ArchivoJson.Cargar<Venta>(rutaArchivoVentas);
        }

        public static void GuardarDatos()
        {
            ArchivoJson.Guardar(rutaArchivoAutores, Autores);
            ArchivoJson.Guardar(rutaArchivoLibros, Libros);
            ArchivoJson.Guardar(rutaArchivoClientes, Clientes);
            ArchivoJson.Guardar(rutaArchivoVentas, Ventas);
        }

        public static void GuardarAutores()
        {
            ArchivoJson.Guardar(rutaArchivoAutores, Autores);
        }

        public static void GuardarLibros()
        {
            ArchivoJson.Guardar(rutaArchivoLibros, Libros);
        }

        public static void GuardarClientes()
        {
            ArchivoJson.Guardar(rutaArchivoClientes, Clientes);
        }

        public static void GuardarVentas()
        {
            ArchivoJson.Guardar(rutaArchivoVentas, Ventas);
        }
    }
}

