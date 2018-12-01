using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Formulario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnConversion(object sender, EventArgs e)
    {
        ServiceReference1.WebServiceSoapClient servicio = new ServiceReference1.WebServiceSoapClient();
        
        try
        {
            double cant = Double.Parse(txtNumero1.Value);
            lblRespuesta.InnerHtml = "Resultado: " + servicio.convetir(cant, select1.Value, select2.Value); 
        }
        catch(Exception e2)
        {
            Console.WriteLine(e2.StackTrace);   
        }
        
    }
}