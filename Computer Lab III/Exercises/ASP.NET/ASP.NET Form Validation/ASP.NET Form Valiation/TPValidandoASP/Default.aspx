<%@ Page Language="C#" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<html>
<head runat="server">
    <title>Formulario</title>
</head>
<body>
    <div>
        <form id="form1" runat="server">
            <asp:Label ID="lblNombreASP" runat="server" Text="Nombre"></asp:Label>
            <br />
            <asp:TextBox ID="txtNombreASP" runat="server" placeholder="Nombre" Width="112px"></asp:TextBox>
            <asp:TextBox ID="txtApellidoASP" runat="server" placeholder="Apellido" Width="112px"></asp:TextBox>
            <br />
            <asp:Label ID="lblUsuario" runat="server" Text="Nombre de usuario"></asp:Label>
            <br />
            <asp:TextBox ID="txtUserASP" runat="server" placeholder="@gmail.com" Width="224px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassASP" runat="server" Text="Contraseña"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassASP" runat="server" Width="224px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassConfirmASP" runat="server" Text="Confirma tu contraseña"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassConfirmASP" runat="server" Width="224px"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateASP" runat="server" Text="Fecha de nacimiento"></asp:Label>
            <br />
            <asp:TextBox ID="txtDayASP" runat="server" placeholder="Día" Width="40px"></asp:TextBox>
            <asp:DropDownList ID="comboMesesASP" runat="server">
                <asp:ListItem>Enero</asp:ListItem>
                <asp:ListItem>Febrero</asp:ListItem>
                <asp:ListItem>Marzo</asp:ListItem>
                <asp:ListItem>Abril</asp:ListItem>
                <asp:ListItem>Mayo</asp:ListItem>
                <asp:ListItem>Junio</asp:ListItem>
                <asp:ListItem>Julio</asp:ListItem>
                <asp:ListItem>Agosto</asp:ListItem>
                <asp:ListItem>Septiembre</asp:ListItem>
                <asp:ListItem>Octubre</asp:ListItem>
                <asp:ListItem>Noviembre</asp:ListItem>
                <asp:ListItem>Diciembre</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtYearASP" runat="server" placeholder="Año" Width="40px"></asp:TextBox>
            <br />
            <asp:Label ID="lblSexoASP" runat="server" Text="Sexo"></asp:Label>
            <br />
            <asp:DropDownList ID="comboSexoASP" runat="server" Width="224px">
                <asp:ListItem Text="Masculino"></asp:ListItem>
                <asp:ListItem Text="Femenino"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="LblPhoneASP" runat="server" Text="Teléfono Móvil"></asp:Label>
            <br />
            <asp:TextBox ID="textPhoneASP" runat="server" Width="224px" placeholder="(XXX) XXX-XXXX"></asp:TextBox>
            <br />
            <asp:Label ID="lblAlternativeMailASP" runat="server" Text="Dirección de correo alternativa"></asp:Label>
            <br />
            <asp:TextBox ID="txtAlternativeMailASP" runat="server" Width="224px"></asp:TextBox>
            <br />
            <asp:Label ID="lblUbicacionASP" runat="server" Text="Ubicación"></asp:Label>
            <br />
            <asp:DropDownList ID="comboUbicacionASP" runat="server" Width="224px">
                <asp:ListItem Text="Argentina"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:CheckBox runat="server" ID="CheckBoxAcceptedAgreement1" />Acepto las Condiciones del servicio y la Política de privacidad de Google.
            <br />
            <asp:CheckBox runat="server" ID="CheckBoxAcceptedAgreement2"/>Google puede utilizar la información de mi cuenta para la personalización de +1 en contenido y anuncios de sitios web que no pertenecen a Google. Más información sobre la personalización.

            <asp:button ID="buttonASP" Text="Siguiente Paso" BackColor="#0066CC" ForeColor="White" ValidationGroup="validaciones" runat="Server" />

            <div style="display:flex; flex-flow:column;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtNombreASP" runat="server" ErrorMessage="Debe introducir el Nombre." ControlToValidate="txtNombreASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionTxtNombreASP" runat="server" ControlToValidate="txtNombreASP" ErrorMessage="*Ingrese sólo letras en el Nombre." ValidationExpression="^[A-Za-z]*$" ValidationGroup="validaciones"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtApellidoASP" runat="server" ErrorMessage="Debe introducir el Apellido." ControlToValidate="txtApellidoASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionTxtApellidoASP" runat="server" ControlToValidate="txtApellidoASP" ErrorMessage="*Ingrese sólo letras en el Apellido." ValidationExpression="^[A-Za-z]*$" ValidationGroup="validaciones"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtUserASP" runat="server" ErrorMessage="Debe introducir el Mail." ControlToValidate="txtUserASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtPassASP" runat="server" ErrorMessage="Debe introducir la Contraseña." ControlToValidate="txtPassASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionTxtPassASP" runat="server" ValidationExpression="^[!@#$%^&*+;:]{1}$" ControlToValidate="txtPassASP" ErrorMessage="La Contraseña debe contener al menos algundo de estos símbolos: !@#$%^&*+;:" ValidationGroup="validaciones"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtPassConfirmASPP" runat="server" ErrorMessage="Debe introducir la Contraseña Confirmada." ControlToValidate="txtPassConfirmASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorPass" runat="server" ErrorMessage="La Contraseña Confirmada no coincide con la Contraseña introducida." ControlToCompare="txtPassASP" ControlToValidate="txtPassConfirmASP" ValidationGroup="validaciones"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtDayASP" runat="server" ErrorMessage="Debe introducir el Día." ControlToValidate="txtDayASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RangeValidator id="RangeValidatorDay"   Type="Integer"   ControlToValidate="txtDayASP"   MaximumValue="31"   MinimumValue="1"   runat="server" ErrorMessage="Día no válido." ValidationGroup="validaciones"/> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtYearASP" runat="server" ErrorMessage="Debe introducir el Año." ControlToValidate="txtYearASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RangeValidator id="RangeValYear"   Type="Integer"   ControlToValidate="txtYearASP"   MaximumValue="2018"   MinimumValue="1930"   runat="server" ErrorMessage="Año no válido." ValidationGroup="validaciones"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextPhoneASP" runat="server" ErrorMessage="Debe introducir el Teléfono." ControlToValidate="textPhoneASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionTextPhoneASP" runat="server" ValidationExpression="^\d{3}-\d{3}-\d{4}$" ErrorMessage="Teléfono no válido. Debe tener este formato: (XXX) XXX-XXXX" ControlToValidate="textPhoneASP" ValidationGroup="validaciones"></asp:RegularExpressionValidator>                
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtAlternativeMailASP" runat="server" ErrorMessage="Debe introducir el Mail Alternativo." ControlToValidate="txtAlternativeMailASP" ValidationGroup="validaciones"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionTxtAlternativeMailASP" runat="server" ValidationExpression="^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$" ErrorMessage="Mail Alternativo no válido." ControlToValidate="txtAlternativeMailASP" ValidationGroup="validaciones"></asp:RegularExpressionValidator>
                <asp:CustomValidator runat="server" ID="CheckBoxRequired" EnableClientScript="true" ErrorMessage="Debe aceptar las políticas de privacidad de Google." OnServerValidate="CheckBoxRequired_ServerValidate" ClientValidationFunction="CheckBoxRequired_ClientValidate" ValidationGroup="validaciones"></asp:CustomValidator>
            </div>
        </form>
    </div>
</body>
</html>
