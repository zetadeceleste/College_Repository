<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Resumen.aspx.cs" Inherits="Resumen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Resumen</title>
    <style>
        label {
            color: black;
        }

        body {
            text-align: center;
        }

        h1 {
            color: black;
            text-decoration: underline;
        }

        h3 {
            color: black;
            text-decoration: underline;
        }

        body {
            margin: 10px;
        }

        #seccion {
            text-align: center;
            border: 1px solid black;
            padding-left: 10px;
            margin-bottom: 10px;
            padding-bottom: 10px;
        }

        table {
            display: inline-block;
        }
    </style>
</head>
<body>
    <h1>Resumen</h1>
    <form runat="server">

        <div id="seccion">
            <table>
                <tr>
                    <td>
                        <h3>Datos Personales</h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblNombre">Nombre: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblApellido">Apellido: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblDni">Dni: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblDomicilio">Domicilio: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblNacionalidad">Nacionalidad: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblSexo">Sexo: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblFecha">Fecha Nacimiento: </label>
                    </td>
                </tr>
            </table>
        </div>

        <div id="seccion">
            <table>
                <tr>
                    <td>
                        <h3>Antecedentes Educacionales</h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblNivel">Nivel De Estudio: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblTitulo">Titulo: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblEstablecimiento">Establecimiento: </label>
                    </td>
                </tr>
            </table>
        </div>

        <div id="seccion">
            <table>
                <tr>
                    <td>
                        <h3>Experiencia Laboral</h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblPeriodo">Periodo de ocupacion: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblLugar">Lugar De Trabajo: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblTarea">Tarea Desempeñada: </label>
                    </td>
                </tr>
            </table>
        </div>

        <div id="seccion">
            <table>
                <tr>
                    <td>
                        <h3>Idiomas</h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblIdioma">Idioma: </label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label runat="server" id="lblNivelConocimiento">Nivel de Conocimiento: </label>
                    </td>
                </tr>
            </table>
        </div>
        <button runat="server" id="btnCerrarSesion" onserverclick="cerrarSesion">Cerrar Sesión</button>

    </form>
</body>
</html>
