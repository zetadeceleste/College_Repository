<html>
    <head>
        <meta charset="UTF-8">
        <title>Ejercicio 1</title>
    </head>
    <body>
        <?php
        $valor1 = $_REQUEST['valor1'];
        $valor2 = $_REQUEST['valor2'];
        settype($valor1, "integer");
        settype($valor2, "integer");
        $matriz = array();

        for ($i = 0; $i < $valor1; $i++) {
            for ($j = 0; $j < $valor1; $j++) {
                if ($valor2 == ($i + 1) + ($j + 1)) {
                    $matriz[$i][$j] = "X";
                } else {
                    $matriz[$i][$j] = "O";
                }
            }
        }
        echo '<table style="border-collapse: collapse; font-family: arial">';
        for ($i = 0; $i < $valor1; $i++) {
            echo '<tr>';
            for ($j = 0; $j < $valor1; $j++) {
                echo '<td style="border: 1px black solid; width: 150px; font-weight: bold; text-align: center">';
                echo $matriz[$i][$j];
                echo '</td>';
            }
            echo '</tr>';
        }
        echo "</table>";
        ?>     
    </body>
</html>
