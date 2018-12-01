using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextBoxNoEmpty : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        validarTexto();
    }

    protected bool validarTexto()
    {
        bool hayTexto = false;
        if (txtBNoEmpty.Text.Length == 0)
        {
            txtBNoEmpty.BorderColor = Color.Red;
            hayTexto = false;
        }
        else
        {
            txtBNoEmpty.BorderColor = Color.Green;
            hayTexto = true;
        }

        return hayTexto;
    }
}