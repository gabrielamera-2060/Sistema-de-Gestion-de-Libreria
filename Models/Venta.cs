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
        private decimal precio;

        public int Id { get => id; set => id = value; }
        public Libro Libro { get => libro; set => libro = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public Cliente Cliente1 { get => cliente; set => cliente = value; }

        public Venta (int id, Libro libro, Cliente cliente, DateTime fechaVenta, decimal precio)
        {
            this.Id = id;
            this.Libro = libro;
            this.cliente = cliente;
            this.FechaVenta = fechaVenta;
            this.Precio = precio;
        }
    }
}
