using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Biblioteca.Models
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string cedula;

        public int Id { get => id; set => id = value;}
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
        public string Apellido 
        { 
            get => apellido; 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("El apellido del autor es obligatorio.");

                apellido = value;
            }
        }
        public string Telefono 
        { 
            get => telefono;
            set
            {
                if (value.Length != 10)
                    throw new Exception("El teléfono debe tener 10 dígitos.");

                telefono = value;
            }
        }
        public string Cedula 
        { 
            get => cedula; 
            set
            {
                if (value.Length != 10)
                {
                    throw new Exception("La cédula debe tener 10 dígitos");
                }
                cedula = value;
            }
        }

        public Cliente (int id, string nombre, string apellido, string telefono, string cedula)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Cedula = cedula;
        }

        public void Imprimir()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Cedula: {Cedula}");
            Console.WriteLine($"Teléfono: {Telefono}");
        }
    }
}
