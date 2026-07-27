using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestion_de_Biblioteca.Models
{
    public class Venta
    {
        private int id;
        private Libro libro;
        private string nombreCliente;
        private DateTime fechaVenta;
        private decimal precio;
    }
}
