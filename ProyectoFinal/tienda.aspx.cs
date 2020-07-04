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
            string cod;
         

            cod = this.grvproducto.SelectedRow.Cells[1].Text;
            Labelprueba.Text = cod; 
        }
    }
}