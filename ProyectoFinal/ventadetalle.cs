using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal
{
    public class ventadetalle
    {
        string codigo_v;
        string codigo_p;
        string cantidad;

        public string Codigo_v { get => codigo_v; set => codigo_v = value; }
        public string Codigo_p { get => codigo_p; set => codigo_p = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
    }
}