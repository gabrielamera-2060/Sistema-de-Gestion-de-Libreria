using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Biblioteca.Models
{
    public class Autor
    {
        private int id;
        private string nombre;
        private string generoLiterario;
        private int cantidadLibros;
        private string correo;

        public int Id { get => id; set => id = value; }
        public string Nombre 
        { 
            get => nombre;
            set  
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("El nombre del autor es obligatorio.");

                nombre = value;
            }
        }
        public string GeneroLiterario 
        { 
            get => generoLiterario;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("El género literario es obligatorio.");

                generoLiterario = value;
            }
        }
        public int CantidadLibros 
        { 
            get => cantidadLibros; 
            set
            {
                if (value < 0)
                    throw new Exception("La cantidad de libros no puede ser negativa.");

                cantidadLibros = value;
            }
        }
        public string Correo { get => correo; set => correo = value; }

        public Autor (int id, string nombre, string generoLiterario, int cantidadLibros, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.GeneroLiterario = generoLiterario;
            this.CantidadLibros = cantidadLibros;
            this.Correo = correo;
        }

        public void Imprimir()
        {
            Console.WriteLine("===== AUTOR =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Género literario: {GeneroLiterario}");
            Console.WriteLine($"Cantidad de libros: {CantidadLibros}");
            Console.WriteLine($"Correo: {Correo}");
        }
    }
}
