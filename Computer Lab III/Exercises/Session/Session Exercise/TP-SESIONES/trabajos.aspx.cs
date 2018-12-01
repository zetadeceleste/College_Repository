using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class trabajos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void siguiente(object sender, EventArgs e)
    {
        Session["Periodo"] = txtPeriodo.Value;
        Session["Lugar"] = txtLugar.Value;
        Session["Tarea"] = txtTarea.Value;
        Server.Transfer("idiomas.aspx");
    }
}