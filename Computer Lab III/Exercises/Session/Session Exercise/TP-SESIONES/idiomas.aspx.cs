using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class idiomas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void siguiente(object sender, EventArgs e)
    {
        Session["Idioma"] = txtIdioma.Value;
        Session["NivelConocimiento"] = txtNivel.Value;
        Server.Transfer("Resumen.aspx");
    }
}