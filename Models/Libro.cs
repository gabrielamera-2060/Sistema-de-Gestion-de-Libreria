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


        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }
        public int AnioPublicacion { get => anioPublicacion; set => anioPublicacion = value; }
        public bool Disponible { get => disponible; set => disponible = value; }

        public Libro(int id, string titulo, string genero, int anioPublicacion, bool disponible)
        {
            Id = id;
            Titulo = titulo;
            Genero = genero;
            AnioPublicacion = anioPublicacion;
            Disponible = disponible;
        }
    }
}
