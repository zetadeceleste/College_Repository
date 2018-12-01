<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body style="font-family: arial">
        <?php
        $cadena = $_REQUEST['cadena'];
        $matriz = str_split($cadena, 1);

        foreach ($matriz as $value) {
            echo "<b>$value </b>";
        }
        ?>
    </body>
</html>

