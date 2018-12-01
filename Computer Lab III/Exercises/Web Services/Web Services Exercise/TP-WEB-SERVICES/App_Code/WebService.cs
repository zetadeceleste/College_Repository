using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }

    [WebMethod]
    public double convetir(double cantidad, string unidad1, string unidad2)
    {
        double resultado = 0;

        //Si son las mismas unidades de medidas
        if (unidad1.Equals(unidad2))
        {
            return cantidad;
        }

        //Km A otra
        if (unidad1.Equals("km") && unidad2.Equals("m"))
        {
            resultado = kmAMetro(cantidad);
        }
        else if (unidad1.Equals("km") && unidad2.Equals("dm"))
        {
            resultado = kmAdm(cantidad);
        }
        else if (unidad1.Equals("km") && unidad2.Equals("cm"))
        {
            resultado = kmAcm(cantidad);
        }
        else if (unidad1.Equals("km") && unidad2.Equals("mm"))
        {
            resultado = kmAmm(cantidad);
        }
        else if (unidad1.Equals("km") && unidad2.Equals("µm"))
        {
            resultado = kmAµm(cantidad);
        }

        //Metro a otra
        if (unidad1.Equals("m") && unidad2.Equals("km"))
        {
            resultado = mAKm(cantidad);
        }
        else if (unidad1.Equals("m") && unidad2.Equals("dm"))
        {
            resultado = mAdm(cantidad);
        }
        else if (unidad1.Equals("m") && unidad2.Equals("cm"))
        {
            resultado = mAcm(cantidad);
        }
        else if (unidad1.Equals("m") && unidad2.Equals("mm"))
        {
            resultado = mAmm(cantidad);
        }
        else if (unidad1.Equals("m") && unidad2.Equals("µm"))
        {
            resultado = mAµm(cantidad);
        }

        //dm A otra
        if (unidad1.Equals("dm") && unidad2.Equals("km"))
        {
            resultado = dmAKm(cantidad);
        }
        else if (unidad1.Equals("dm") && unidad2.Equals("m"))
        {
            resultado = dmAm(cantidad);
        }
        else if (unidad1.Equals("dm") && unidad2.Equals("cm"))
        {
            resultado = dmAcm(cantidad);
        }
        else if (unidad1.Equals("dm") && unidad2.Equals("mm"))
        {
            resultado = dmAmm(cantidad);
        }
        else if (unidad1.Equals("dm") && unidad2.Equals("µm"))
        {
            resultado = dmAµm(cantidad);
        }

        //cm A otra
        if (unidad1.Equals("cm") && unidad2.Equals("km"))
        {
            resultado = cmAKm(cantidad);
        }
        else if (unidad1.Equals("cm") && unidad2.Equals("m"))
        {
            resultado = cmAm(cantidad);
        }
        else if (unidad1.Equals("cm") && unidad2.Equals("dm"))
        {
            resultado = cmAdm(cantidad);
        }
        else if (unidad1.Equals("cm") && unidad2.Equals("mm"))
        {
            resultado = cmAmm(cantidad);
        }
        else if (unidad1.Equals("cm") && unidad2.Equals("µm"))
        {
            resultado = cmAµm(cantidad);
        }

        //mm A otra
        if (unidad1.Equals("mm") && unidad2.Equals("km"))
        {
            resultado = mmAKm(cantidad);
        }
        else if (unidad1.Equals("mm") && unidad2.Equals("m"))
        {
            resultado = mmAm(cantidad);
        }
        else if (unidad1.Equals("mm") && unidad2.Equals("dm"))
        {
            resultado = mmAdm(cantidad);
        }
        else if (unidad1.Equals("mm") && unidad2.Equals("cm"))
        {
            resultado = mmAcm(cantidad);
        }
        else if (unidad1.Equals("mm") && unidad2.Equals("µm"))
        {
            resultado = mmAµm(cantidad);
        }

        //µm A otra
        if (unidad1.Equals("µm") && unidad2.Equals("km"))
        {
            resultado = µmAKm(cantidad);
        }
        else if (unidad1.Equals("µm") && unidad2.Equals("m"))
        {
            resultado = µmAm(cantidad);
        }
        else if (unidad1.Equals("µm") && unidad2.Equals("dm"))
        {
            resultado = µmAdm(cantidad);
        }
        else if (unidad1.Equals("µm") && unidad2.Equals("cm"))
        {
            resultado = µmAcm(cantidad);
        }
        else if (unidad1.Equals("µm") && unidad2.Equals("mm"))
        {
            resultado = µmAmm(cantidad);
        }

        return resultado;
    }

    //Km A Otra Unidad
    public double kmAMetro(double cantidad)
    {
        return cantidad * 1000;
    }

    public double kmAdm(double cantidad)
    {
        return cantidad * 10000;
    }

    public double kmAcm(double cantidad)
    {
        return cantidad * 100000;
    }

    public double kmAmm(double cantidad)
    {
        return cantidad * 1e+6;
    }

    public double kmAµm(double cantidad)
    {
        return cantidad * 1e+9;
    }

    //m A otra unidad
    public double mAKm(double cantidad)
    {
        return cantidad / 1000;
    }

    public double mAdm(double cantidad)
    {
        return cantidad * 10;
    }

    public double mAcm(double cantidad)
    {
        return cantidad * 100;
    }

    public double mAmm(double cantidad)
    {
        return cantidad * 1000;
    }

    public double mAµm(double cantidad)
    {
        return cantidad * 1e+6;
    }

    //dm A otra unidad
    public double dmAKm(double cantidad)
    {
        return cantidad / 10000;
    }

    public double dmAm(double cantidad)
    {
        return cantidad / 10;
    }

    public double dmAcm(double cantidad)
    {
        return cantidad * 10;
    }

    public double dmAmm(double cantidad)
    {
        return cantidad * 100;
    }

    public double dmAµm(double cantidad)
    {
        return cantidad * 100000;
    }

    //cm A otra
    public double cmAKm(double cantidad)
    {
        return cantidad / 100000;
    }

    public double cmAm(double cantidad)
    {
        return cantidad / 100;
    }

    public double cmAdm(double cantidad)
    {
        return cantidad / 10;
    }

    public double cmAmm(double cantidad)
    {
        return cantidad * 10;
    }

    public double cmAµm(double cantidad)
    {
        return cantidad * 10000;
    }

    //mm A otra
    public double mmAKm(double cantidad)
    {
        return cantidad / 1e+6;
    }

    public double mmAm(double cantidad)
    {
        return cantidad / 1000;
    }

    public double mmAdm(double cantidad)
    {
        return cantidad / 100;
    }

    public double mmAcm(double cantidad)
    {
        return cantidad / 10;
    }

    public double mmAµm(double cantidad)
    {
        return cantidad * 1000;
    }

    //µm A otra
    public double µmAKm(double cantidad)
    {
        return cantidad / 1e+9;
    }

    public double µmAm(double cantidad)
    {
        return cantidad / 1e+6;
    }

    public double µmAdm(double cantidad)
    {
        return cantidad / 100000;
    }

    public double µmAcm(double cantidad)
    {
        return cantidad / 10000;
    }

    public double µmAmm(double cantidad)
    {
        return cantidad / 1000;
    }

}
