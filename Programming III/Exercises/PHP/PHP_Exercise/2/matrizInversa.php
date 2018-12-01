<html>
    <head>
        <meta charset="UTF-8">
        <title>Ejercicio 2</title>
    </head>
    <body style="font-family: arial">
        <?php
        $valor1 = $_REQUEST['valor1'];
        $valor2 = $_REQUEST['valor2'];
        settype($valor1, "integer");
        settype($valor2, "integer");
        $elementosIdentidad = 0;
        $elementosNoIdentidad = 0;

        if ($valor1 == $valor2) {
            $matriz = array();
            for ($i = 0; $i < $valor1; $i++) {
                for ($j = 0; $j < $valor2; $j++) {
                    if ($i + $j == $valor1 - 1) {
                        $matriz[$i][$j] = 1;
                        $elementosIdentidad++;
                    } else {
                        $matriz[$i][$j] = 0;
                        $elementosNoIdentidad++;
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
            echo '</table>';
            echo '<br>';

            echo '<b>Elementos Identidad: </b>';
            echo $elementosIdentidad;
            echo ' elementos';
            echo '<br>';
            echo '<b>Elementos No Identidad: </b>';
            echo $elementosNoIdentidad;
            echo ' elementos';
        } else {
            echo '<h1>ERROR: Los valores deben ser iguales</h1>';
        }
        ?>
    </body>
</html>

