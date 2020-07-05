using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ProyectoFinal
{
    public partial class tienda : System.Web.UI.Page
    {
        List<productos> producto = new List<productos>();
        static List<carritodetalle> listadetalle = new List<carritodetalle>();
        static string cod, nproducto;
        int cantidad;
        static int precio;
        protected void Page_Load(object sender, EventArgs e)
        {
           var archivo= Server.MapPath("~/Archivo/producto.txt");

            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(stream);


            while (Reader.Peek() > -1)
            {
                productos produ = new productos();
                produ.Codigo = Reader.ReadLine();
                produ.Nombre = Reader.ReadLine();
                produ.Marca = Reader.ReadLine();
                produ.Descripcion = Reader.ReadLine();
                produ.Imagen = Reader.ReadLine();
                produ.Pcompra = Convert.ToInt32(Reader.ReadLine());
                produ.Pventa = Convert.ToInt32 (Reader.ReadLine());
                produ.Cantidad = Convert.ToInt32(Reader.ReadLine());

                producto.Add(produ);
            }

            grvproducto.DataSource = producto;
            grvproducto.DataBind();
        }

        protected void grvproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            cod = this.grvproducto.SelectedRow.Cells[1].Text;
            nproducto = this.grvproducto.SelectedRow.Cells[2].Text;
            precio = Convert.ToInt32(this.grvproducto.SelectedRow.Cells[7].Text);
            TextBox1.Text = this.grvproducto.SelectedRow.Cells[8].Text;

        }

        protected void add_Click(object sender, EventArgs e)
        {
            carritodetalle cd = new carritodetalle();
            cd.Codigoproducto = cod;
            cd.Nombreproducto = nproducto;
            cd.Cantidad = Convert.ToInt32(TextBox2.Text);
            cd.Precio = precio;
            cd.Total = precio * cd.Cantidad;

            listadetalle.Add(cd);

            int stotal = listadetalle.Sum(l => l.Total);
            Lbltotal.Text = "Total:" + stotal;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int stotal = listadetalle.Sum(l => l.Total);
            Lbltotal.Text = Convert.ToString(stotal);

            Lbltotal.Text = "Total:" + stotal;
            GridView1.DataSource = listadetalle;
            GridView1.DataBind();

        }
    }
}