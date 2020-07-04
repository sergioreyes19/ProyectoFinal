using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ProyectoFinal
{
    public partial class Productos : System.Web.UI.Page
    {
        List<Marcas> marcas = new List<Marcas>();
        protected void Page_Load(object sender, EventArgs e)
        {
            var archivo = Server.MapPath("~/Archivo/marca.txt");

            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader Reader = new StreamReader(stream);


            while (Reader.Peek() > -1)
            {

                Marcas mar = new Marcas();
                mar.Codigo = Convert.ToInt32(Reader.ReadLine());
                mar.Nombre = Reader.ReadLine();
                marcas.Add(mar);
            }

            if (!IsPostBack)
            {

                DropDownMarca.DataValueField = "Codigo";
                DropDownMarca.DataTextField = "Nombre";
                DropDownMarca.DataSource = marcas;
                DropDownMarca.DataBind(); 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var archivo = Server.MapPath("~/Archivo/producto.txt");

            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(Txtcodigo.Text);
            writer.WriteLine(Txtnombre.Text);
            writer.WriteLine(DropDownMarca.SelectedValue);
            writer.WriteLine(txtdescripcion.Text);
            writer.WriteLine("imagen");
            writer.WriteLine(Txtpreciocompra.Text);
            writer.WriteLine(Txtprecioventa.Text);
            writer.WriteLine(Txtcantidad.Text);



                writer.Close();  
        }
    }
}