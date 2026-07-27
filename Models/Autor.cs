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
        public string Nombre { get => nombre; set => nombre = value; }
        public string GeneroLiterario { get => generoLiterario; set => generoLiterario = value; }
        public int CantidadLibros { get => cantidadLibros; set => cantidadLibros = value; }
        public string Correo { get => correo; set => correo = value; }

        public Autor (int id, string nombre, string generoLiterario, int cantidadLibros, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.GeneroLiterario = generoLiterario;
            this.CantidadLibros = cantidadLibros;
            this.Correo = correo;
        }
    }
}
