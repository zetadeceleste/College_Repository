<%@ Page Language="C#" AutoEventWireup="true" CodeFile="trabajos.aspx.cs" Inherits="trabajos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Trabajos</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>Periodo de ocupacion: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtPeriodo" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Lugar de trabajo: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtLugar" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Tarea desempeñada: </label>
                </td>
                <td>
                    <input type="text" runat="server" id="txtTarea" />
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
