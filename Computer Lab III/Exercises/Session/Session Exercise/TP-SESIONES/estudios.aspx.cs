using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class estudios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void siguiente(object sender, EventArgs e)
    {
        Session["Nivel"] = txtNivel.Value;
        Session["Titulo"] = txtTitulo.Value;
        Session["Establecimiento"] = txtEstablecimiento.Value;
        Server.Transfer("trabajos.aspx");
    }
}