<%@ Page Language="C#" AutoEventWireup="true" CodeFile="datospersonales.aspx.cs" Inherits="datospersonales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Datos Personales</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>Nombre: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtNombre" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Apellido: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtApellido" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>DNI: </label>

                </td>
                <td>
                    <input type="text" runat="server" id="txtDni" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Domicilio: </label>

                </td>
                <td>
                    <input type="text" runat="server" id="txtDomicilio" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Nacionalidad: </label>

                </td>
                <td>
                    <input type="text" runat="server" id="txtNacionalidad" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Sexo: </label>

                </td>
                <td>
                    <input type="text" runat="server" id="txtSexo" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Fecha Nacimiento: </label>

                </td>
                <td>
                    <input type="text" runat="server" id="txtFechaNacimiento" />
                </td>
            </tr>

            <tr>
                <td>
                    <br />
                    <button runat="server" onserverclick="siguiente">Siguiente</button>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
