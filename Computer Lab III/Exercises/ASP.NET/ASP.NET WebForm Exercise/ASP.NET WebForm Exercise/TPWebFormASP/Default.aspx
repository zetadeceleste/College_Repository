<%@ Page Language="C#" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<html>
<head runat="server">
    <title>Formulario</title>
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .auto-style2 {
            width: 130px;
        }
        .auto-style3 {
            height: 27px;
            width: 130px;
        }
        .auto-style4 {
            height: 9px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Listado de cursos</h1>
        <table border="1" style="height: 141px; width: 462px">
            <tr>
                <td></td>
                <td><strong>COMPONENTES</strong></td>
            </tr>
            <tr>
                <td>Caja de Texto</td>
                <td><asp:TextBox ID="txtNombreASP" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Combo</td>
                <td><asp:DropDownList ID="comboASP" runat="server">
                        <asp:ListItem Selected="True">Argentina</asp:ListItem>
                        <asp:ListItem>Italia</asp:ListItem>
                        <asp:ListItem>Alemania</asp:ListItem>
                        <asp:ListItem>Portugal</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Imagen</td>
                <td><asp:Image ID="imgASP" runat="server" ImageUrl="~/Papyrus.jpg" /></td>
            </tr>
            <tr>
                <td class="auto-style1">Checkbox</td>
                <td class="auto-style1">
                    <asp:CheckBoxList ID="checkBoxASP" runat="server">
                        <asp:ListItem>SI</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Hipervínculo</td>
                <td class="auto-style1">
                    <asp:HyperLink ID="linkASP" runat="server">Google</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Radio Button</td>
                <td class="auto-style1">
                    <asp:RadioButtonList ID="radioBtnASP" runat="server">
                        <asp:ListItem>Alta</asp:ListItem>
                        <asp:ListItem>Media</asp:ListItem>
                        <asp:ListItem>Baja</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Campo Oculto</td>
                <td class="auto-style4">
                    <asp:HiddenField ID="campoOcultoASP" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Botón</td>
                <td class="auto-style1">
                    <asp:Button ID="btnASP" runat="server" Text="Button" OnClick="Button_Click"/>
                </td>
            </tr>          
            <tr>
                <td class="auto-style2">Datos Ingresados</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Caja de Texto:</td>
                <td>
                    <asp:TextBox ID="txtNombreASP_result" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Combo:</td>
                <td>
                    <asp:TextBox ID="txtComboASP_result" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Imagen:</td>
                <td>
                    <asp:Image ID="imgASP_result" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Checkbox:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCheckBoxASP_result" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Hipervínculo:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtLinkASP_result" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Radio Button:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtRadioBtnASP_result" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Campo Oculto:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtCampoOcultoASP_result" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
