using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class ReporteTotalventa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Calendar1.SelectedDate.ToShortDateString();
            Calendar2.SelectedDate.ToShortDateString();

            Label1.Text = Calendar1.SelectedDate.ToShortDateString() + " " + Calendar2.SelectedDate.ToShortDateString();
        }
    }
}