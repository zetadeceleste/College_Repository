<%-- 
    Document   : primerPagina
    Created on : Nov 11, 2018, 8:51:33 PM
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
        <h1>Formulario de Carga</h1>
        <form action="segundaPagina.jsp">
            Filas: <input type = "number" name = "filas">
            <br />
            Columnas: <input type = "number" name = "columnas" />
            <input type = "submit" value = "Submit" />
        </form>
    </body>
</html>
