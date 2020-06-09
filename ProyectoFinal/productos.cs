using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal
{
    public class productos
    {
        string codigo;
        string nombre;
        string marca;
        string descripcion;
        string imagen;
        float pcompra;
        float Pventa;
        int cantidad;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public float Pcompra { get => pcompra; set => pcompra = value; }
        public float Pventa1 { get => Pventa; set => Pventa = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}