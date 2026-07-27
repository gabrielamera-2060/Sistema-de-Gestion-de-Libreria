using Sistema_de_Gestion_de_Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Biblioteca.Generales
{
    public class Database
    {
        public List<Autor> Autores { get; set; } = new List<Autor>();
        public List<Libro> Libros { get; set; } = new List<Libro>();
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Venta> Ventas { get; set; } = new List<Venta>();

        public Database()
        {
            Autores = new List<Autor>();
            Libros = new List<Libro>();
            Clientes = new List<Cliente>();
            Ventas = new List<Venta>();
        }
    }
}

