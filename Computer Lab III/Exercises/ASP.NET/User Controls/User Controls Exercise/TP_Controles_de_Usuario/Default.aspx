<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="RegristoAyuda" %>

<%@ Register Src="~/TextBoxNoEmpty.ascx" TagPrefix="uc1" TagName="TextBoxNoEmpty" %>
<%@ Register Src="~/TextBoxCuit.ascx" TagPrefix="uc1" TagName="TextBoxCuit" %>
<%@ Register Src="~/TextBoxMayorEdad.ascx" TagPrefix="uc1" TagName="TextBoxMayorEdad" %>
<%@ Register Src="~/ComboPaises.ascx" TagPrefix="uc1" TagName="ComboPaises" %>
<%@ Register Src="~/RadioButtonSex.ascx" TagPrefix="uc1" TagName="RadioButtonSex" %>
<%@ Register Src="~/RangoHijosMenores.ascx" TagPrefix="uc1" TagName="RangoHijosMenores" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Registro Ayuda</title>
    <style>
        body {
            text-align: center;
        }

        td {
            border: 1px solid black;
            padding: 10px;
        }

        table {
            border-collapse: collapse;
            display: inline-block;
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <h1>Registración de Ayuda Social Por Hijos</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label>Apellido</label>
                </td>
                <td>
                    <uc1:TextBoxNoEmpty runat="server" ID="TextBoxNoEmpty" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Nombre</label>
                </td>
                <td>
                    <uc1:TextBoxNoEmpty runat="server" ID="TextBoxNoEmpty1" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>N° de CUIT</label>
                </td>
                <td>
                    <uc1:TextBoxCuit runat="server" ID="TextBoxCuit" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>Edad del solicitante</label>
                </td>
                <td>
                    <uc1:TextBoxMayorEdad runat="server" ID="TextBoxMayorEdad" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Sexo</label>
                </td>
                <td>
                    <uc1:RadioButtonSex runat="server" ID="RadioButtonSex" />
                </td>
            </tr>

            <tr>
                <td>
                    <label>Nacionalidad</label>
                </td>
                <td>
                    <uc1:ComboPaises runat="server" ID="ComboPaises" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>N° de hijos menores de edad</label>
                </td>
                <td>
                    <uc1:RangoHijosMenores runat="server" ID="RangoHijosMenores" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <button runat="server" type="submit">Submit</button>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
