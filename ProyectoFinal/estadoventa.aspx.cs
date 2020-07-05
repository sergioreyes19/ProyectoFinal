using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ProyectoFinal
{
    public partial class estadoventa : System.Web.UI.Page
    {

        // ventaencabezado se le agregan todos los registros del archivo de texto
        static List<Ventaencabezado> ventaencabezado = new List<Ventaencabezado>();
        // vc se le agregan todos los registros con estado No
        static List<Entregable> entregable = new List<Entregable>();


        static int posicionamodificar;

        //Variables Global para poder utilizarlos en cualquier funcion
        static string codigo;
        static string nit;
        static DateTime fecha;
        static decimal total;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var archivo = Server.MapPath("~/Archivo/ventaencabezado.txt");

                FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                StreamReader Reader = new StreamReader(stream);
            
                while (Reader.Peek() > -1)
                {
                    Ventaencabezado ven = new Ventaencabezado();
                    ven.Codigo = Reader.ReadLine();
                    ven.Nit = Reader.ReadLine();
                    ven.Fecha = Convert.ToDateTime(Reader.ReadLine());
                    ven.Total = Convert.ToDecimal (Reader.ReadLine()); 
                    ven.Estado = Reader.ReadLine();
                    ventaencabezado.Add(ven);
                }


                for (int i = 0; i < ventaencabezado.Count; i++)
                {
                    if (ventaencabezado[i].Estado == "No")
                    {
                        Entregable ven = new Entregable();
                        ven.Codigo = ventaencabezado[i].Codigo;
                        ven.Nit = ventaencabezado[i].Nit;
                        ven.Fecha = ventaencabezado[i].Fecha;
                        ven.Total = ventaencabezado[i].Total;
                        ven.Estado = ventaencabezado[i].Estado;

                        entregable.Add(ven);
                    }
                }
            
                Reader.Close();
            
                GridView1.DataSource = entregable;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo = GridView1.SelectedRow.Cells[1].Text;
            Label1.Text = Convert.ToString(ventaencabezado.Count);
            for (int i = 0; i < ventaencabezado.Count; i++)
            {
                if (ventaencabezado[i].Codigo == codigo)
                {
                    codigo = ventaencabezado[i].Codigo;
                    nit = ventaencabezado[i].Nit;
                    fecha = ventaencabezado[i].Fecha;
                    total = ventaencabezado[i].Total;
                    posicionamodificar = i;
                    Label1.Text = "Cambio de posicion. " + posicionamodificar;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ventaencabezado[posicionamodificar].Codigo = codigo;
            ventaencabezado[posicionamodificar].Nit = nit;
            ventaencabezado[posicionamodificar].Fecha = fecha;
            ventaencabezado[posicionamodificar].Total = total;
            ventaencabezado[posicionamodificar].Estado = "Si";

            var archivo = Server.MapPath("~/Archivo/ventaencabezado.txt");

            Label1.Text = Convert.ToString(ventaencabezado.Count);

            FileStream stream = new FileStream(archivo, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < ventaencabezado.Count; i++)
            {
                writer.WriteLine(ventaencabezado[i].Codigo);
                writer.WriteLine(ventaencabezado[i].Nit);
                writer.WriteLine(ventaencabezado[i].Fecha);
                writer.WriteLine(ventaencabezado[i].Total);
                writer.WriteLine(ventaencabezado[i].Estado);
            }
            writer.Close();
        }
    }
}