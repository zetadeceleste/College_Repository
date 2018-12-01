using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TextBoxMayorEdad : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        validarEdad();
    }

    protected bool validarEdad()
    {
        int edad;
        try
        {
            edad = Int16.Parse(txtBMayorEdad.Text);
            if (edad >= 18 && edad < 130)
            {
                txtBMayorEdad.BorderColor = Color.Green;
                return true;
            }
            else
            {
                txtBMayorEdad.BorderColor = Color.Red;
                return false;
            }
        }
        catch (Exception e)
        {
            txtBMayorEdad.BorderColor = Color.Red;
            return false;
        }
    }
}