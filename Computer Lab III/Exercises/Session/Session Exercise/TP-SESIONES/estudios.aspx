<%@ Page Language="C#" AutoEventWireup="true" CodeFile="estudios.aspx.cs" Inherits="estudios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Estudios</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>Nivel de estudio: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtNivel" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>Titulo: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtTitulo" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>Establecimiento: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtEstablecimiento" />
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
