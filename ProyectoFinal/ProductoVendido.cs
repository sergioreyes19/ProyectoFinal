using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal
{
    public class ProductoVendido
    {
        string producto;
        int cantidad;

        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}