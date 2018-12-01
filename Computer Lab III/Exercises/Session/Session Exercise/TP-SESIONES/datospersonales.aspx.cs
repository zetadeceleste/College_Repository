using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class datospersonales : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void siguiente(object sender, EventArgs e)
    {
        Session["Nombre"] = txtNombre.Value;
        Session["Apellido"] = txtApellido.Value;
        Session["Dni"] = txtDni.Value;
        Session["Domicilio"] = txtDomicilio.Value;
        Session["Nacionalidad"] = txtNacionalidad.Value;
        Session["Sexo"] = txtSexo.Value;
        Session["FechaNacimiento"] = txtFechaNacimiento.Value;
        Server.Transfer("estudios.aspx");
    }
}