using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ProyectoFinal
{
    public partial class Editar_productos : System.Web.UI.Page

    {
        

        static List<productos> producto = new List<productos>();

        static int posicionamodificar;

        //Variables Global para poder utilizarlos en cualquier funcion
       static string codigo;
       static string nombre;
       static string marca;
       static string descripcion;
       static string imagen;
       static int pcompra;
       static int pventa;
       static int cantidad;

        protected void Page_Load(object sender, EventArgs e)

           
        {
            if (!IsPostBack)
            {


                var archivo = Server.MapPath("~/Archivo/producto.txt");

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
                    produ.Pventa = Convert.ToInt32(Reader.ReadLine());
                    produ.Cantidad = Convert.ToInt32(Reader.ReadLine());

                    producto.Add(produ);
                }

                GridView1.DataSource = producto;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigo = GridView1.SelectedRow.Cells[1].Text;
            Button1.Text = Convert.ToString(producto.Count);
            for (int i = 0; i < producto.Count; i++)
            {
                if (producto[i].Codigo == codigo)
                {
                    TextBox1.Text = producto[i].Codigo;
                    TextBox2.Text = producto[i].Nombre;
                    TextBox3.Text = producto[i].Marca;
                    TextBox4.Text = producto[i].Descripcion;
                    TextBox8.Text = producto[i].Imagen;
                    TextBox6.Text = Convert.ToString(producto[i].Pcompra);
                    TextBox7.Text = Convert.ToString(producto[i].Pventa);
                    TextBox5.Text = Convert.ToString(producto[i].Cantidad);


                    posicionamodificar = i;
                    Button1.Text = "Buscar. " + posicionamodificar;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            producto[posicionamodificar].Codigo = TextBox1.Text;
            producto[posicionamodificar].Nombre = TextBox2.Text;
            producto[posicionamodificar].Marca = TextBox3.Text;
            producto[posicionamodificar].Descripcion = TextBox4.Text;
            producto[posicionamodificar].Imagen = TextBox8.Text;
            producto[posicionamodificar].Pcompra = Convert.ToInt32(TextBox6.Text);
            producto[posicionamodificar].Pventa = Convert.ToInt32(TextBox7.Text);
            producto[posicionamodificar].Cantidad =Convert.ToInt32(TextBox5.Text);


            var archivo = Server.MapPath("~/Archivo/producto.txt");

            Button1.Text = Convert.ToString(producto.Count);

            FileStream stream = new FileStream(archivo, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < producto.Count; i++)
            {
                writer.WriteLine(producto[i].Codigo);
                writer.WriteLine(producto[i].Nombre);
                writer.WriteLine(producto[i].Marca);
                writer.WriteLine(producto[i].Descripcion);
                writer.WriteLine(producto[i].Imagen);
                writer.WriteLine(producto[i].Pcompra);
                writer.WriteLine(producto[i].Pventa);
                writer.WriteLine(producto[i].Cantidad);
            }
            writer.Close();
        }
    }
}