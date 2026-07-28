using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Biblioteca.Models
{
    public class Libro
    {
        private int id;
        private string titulo;
        private string genero;
        private int anioPublicacion;
        private bool disponible;
        private decimal precio;
        private Autor autor;


        public int Id { get => id; set => id = value; }
        public string Titulo
        { 
            get => titulo; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("El título es obligatorio.");

                titulo = value;
            }
        }
        public string Genero 
        { 
            get => genero; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("El género es obligatorio.");

                genero = value;
            }
        }
        public int AnioPublicacion { get => anioPublicacion; set => anioPublicacion = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public Autor Autor { get => autor; set => autor = value; }

        public decimal Precio 
        { 
            get => precio; 
            set
            {
                if (value <= 0)
                    throw new Exception("El precio debe ser mayor que cero.");

                precio = value;
            }
        }

        public Libro(int id, string titulo, string genero, int anioPublicacion, bool disponible, decimal precio, Autor autor)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Genero = genero;
            this.AnioPublicacion = anioPublicacion;
            this.Disponible = disponible;
            this.Autor = autor;
            this.Precio = precio;
        }

        public void Imprimir()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor.Nombre}");
            Console.WriteLine($"Género: {Genero}");
            Console.WriteLine($"Precio: ${Precio}");
            Console.WriteLine($"Disponible: {Disponible}");
        }
    }
}
