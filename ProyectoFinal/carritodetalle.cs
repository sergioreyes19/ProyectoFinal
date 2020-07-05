using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal
{
    public class carritodetalle
    {
        
        string codigoproducto;
        string nombreproducto;
        int cantidad;
        int precio;
        int total;
        public string Codigoproducto { get => codigoproducto; set => codigoproducto = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Total { get => total; set => total = value; }
        
    }
}