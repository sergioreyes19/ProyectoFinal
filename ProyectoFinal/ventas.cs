﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal
{
    public class ventas
    {
        string codigo;
        string nit;
        DateTime fecha;
        float total;
        string estado;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nit { get => nit; set => nit = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Total { get => total; set => total = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}