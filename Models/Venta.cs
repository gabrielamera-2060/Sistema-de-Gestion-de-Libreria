using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Biblioteca.Models
{
    public class Venta
    {
        private int id;
        private Libro libro;
        private Cliente cliente;
        private DateTime fechaVenta;
        private decimal total;

        public int Id { get => id; set => id = value; }
        public Libro Libro 
        { 
            get => libro; 
            set
            {
                if (value == null)
                    throw new Exception("Debe seleccionar un libro.");

                libro = value;
            }
        }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public decimal Total 
        { 
            get => total; 
            set
            {
                if (value <= 0)
                    throw new Exception("El precio debe ser mayor que cero.");

                total = value;
            }
        }
        public Cliente Cliente1 { get => cliente; set => cliente = value; }

        public Venta (int id, Libro libro, Cliente cliente, DateTime fechaVenta, decimal precio)
        {
            this.Id = id;
            this.Libro = libro;
            this.cliente = cliente;
            this.FechaVenta = fechaVenta;
            this.Total = total;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Venta: {Id}");
            Console.WriteLine($"Libro: {Libro.Titulo}");
            Console.WriteLine($"Cliente: {Cliente1}");
            Console.WriteLine($"Fecha: {FechaVenta}");
            Console.WriteLine($"Total: {Total}");
        }
    }
}
