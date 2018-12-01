using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Resumen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Datos personales
        lblNombre.InnerHtml = "Nombre: " + Session["Nombre"];
        lblApellido.InnerHtml = "Apellido: " + Session["Apellido"];
        lblDni.InnerHtml = "Dni: " + Session["Dni"];
        lblDomicilio.InnerHtml = "Domicilio: " + Session["Domicilio"];
        lblNacionalidad.InnerHtml = "Nacionalidad: " + Session["Nacionalidad"];
        lblSexo.InnerHtml = "Sexo: " + Session["Sexo"];
        lblFecha.InnerHtml = "Fecha: " + Session["FechaNacimiento"];

        //Antecedentes educacionales
        lblNivel.InnerHtml = "Nivel De Estudio: " + Session["Nivel"];
        lblTitulo.InnerHtml = "Titulo: " + Session["Titulo"];
        lblEstablecimiento.InnerHtml = "Establecimiento: " + Session["Establecimiento"];

        //Experiencia Laboral
        lblPeriodo.InnerHtml = "Periodo de ocupacion: " + Session["Periodo"];
        lblLugar.InnerHtml = "Lugar De Trabajo: " + Session["Lugar"];
        lblTarea.InnerHtml = "Tarea: " + Session["Tarea"];

        //Idiomas
        lblIdioma.InnerHtml = "Idioma: " + Session["Idioma"];
        lblNivelConocimiento.InnerHtml = "Nivel De Conocimiento: " + Session["NivelConocimiento"];

    }

    protected void cerrarSesion(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
    }
}