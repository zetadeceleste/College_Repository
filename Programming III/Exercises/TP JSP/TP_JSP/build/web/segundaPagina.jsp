<%-- 
    Document   : segundaPagina
    Created on : Nov 11, 2018, 8:51:43 PM
    Author     : Celes
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Ejercicio 1</title>
    </head>
    <body>
        <h1>Tabla:</h1>
        <table>
            <%  String filas = request.getParameter("filas");
                String columnas = request.getParameter("columnas");
                Integer filasInt = Integer.parseInt(filas);
                Integer columnasInt = Integer.parseInt(columnas);
                for (int i = 1; i <= filasInt; i++) { %>
            <tr>
                <%for (int j = 1; j <= columnasInt; j++) {%>
                <td style="border: 1px solid black"> <%= i%>.<%= j%></td>
                <%}%>
            </tr>
            <%}%>
        </table>
    </body>
</html>
