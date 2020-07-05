using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ProyectoFinal
{
    public partial class Reportes : System.Web.UI.Page
    {
        static List<productos> producto = new List<productos>();
        static List<ventadetalle> venta = new List<ventadetalle>();
        static List<ProductoVendido> listavendido = new List<ProductoVendido>();

        int cantidadv = 0;
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


                var archivodetalle = Server.MapPath("~/Archivo/ventadetalle.txt");

                FileStream streamd = new FileStream(archivodetalle, FileMode.Open, FileAccess.Read);
                StreamReader Readerd = new StreamReader(streamd);

                while (Readerd.Peek() > -1)
                {
                    ventadetalle ventade = new ventadetalle();
                    ventade.Codigo_p = Readerd.ReadLine();
                    ventade.Codigo_v  = Readerd.ReadLine();
                    ventade.Cantidad= Convert.ToInt32(Readerd.ReadLine());

                    venta.Add(ventade);
                }


                foreach (var v in venta)
                {

                    productos pro = producto.Find(p => p.Codigo == v.Codigo_p);
                    //cantidadv = venta.Sum(ve => v.Cantidad);

                    ProductoVendido pvendido = new ProductoVendido();
                    pvendido.Cantidad = cantidadv;

                    listavendido.Add(pvendido);

                }
                GridView1.DataSource = producto;
                GridView1.DataBind();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
 }

 