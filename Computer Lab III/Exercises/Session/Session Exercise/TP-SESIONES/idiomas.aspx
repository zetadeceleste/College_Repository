<%@ Page Language="C#" AutoEventWireup="true" CodeFile="idiomas.aspx.cs" Inherits="idiomas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Idiomas</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>Idioma: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtIdioma" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Nivel de conocimiento: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtNivel" />
                </td>
            </tr>

            <tr>
                <td>
                    <button runat="server" onserverclick="siguiente">Siguiente</button>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
