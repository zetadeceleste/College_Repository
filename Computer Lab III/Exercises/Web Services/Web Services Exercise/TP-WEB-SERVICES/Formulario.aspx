<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Formulario.aspx.cs" Inherits="Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulario Web</title>
    <style>
        body {
            text-align:center;
        }
        table {
            display:inline-block;
            border: 1px solid black;
            border-collapse: collapse;
        }
        td {
            padding: 30px;
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <h1>Conversor de longitudes</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>Quiero Convertir: </label>
                    <input type="text" id="txtNumero1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <select id="select1" runat="server">
                        <option value="km">Kilómetro</option>
                        <option value="m">Metro</option>
                        <option value="dm">Decímetro</option>
                        <option value="cm">Centímetro</option>
                        <option value="mm">Milímetro</option>
                        <option value="µm">Micrómetro</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <label>A</label>
                </td>

            </tr>
            <tr>
                <td colspan="2">
                    <select id="select2" runat="server">
                        <option value="km">Kilómetro</option>
                        <option value="m">Metro</option>
                        <option value="dm">Decímetro</option>
                        <option value="cm">Centímetro</option>
                        <option value="mm">Milímetro</option>
                        <option value="µm">Micrómetro</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <button runat="server" onserverclick="btnConversion">Convertir</button>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <label id="lblRespuesta" runat="server">Resultado: </label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
