package conexion;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 * Clase encargada de conectarse a una Base de datos
 * @author Jeremias Reyes
 */
public class ConexionBD {

    Connection conexion = null;

    /**
     * Metodo encargado de abrir la conexion con la base de datos.
     * @param host Host al cual se va a conectar la base de datos.
     * @param puerto Puerto mediante el cual se va a establecer la conexion.
     * @param baseDatos Nombre de la base de datos a la cual se quiere acceder.
     * @param usuario Nombre del usuario a conectarse a la base de datos.
     * @param clave Clave para conectarse a la base de datos.
     * @return Devuelve un objeto de tipo Connection.
     */

    public Connection abrirConexionBD(String host, int puerto, String baseDatos, String usuario, String clave) {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            String urlConexion = "jdbc:mysql://" + host + ":" + puerto + "/" + baseDatos;
            conexion = DriverManager.getConnection(urlConexion, usuario, clave);
            if (conexion == null) {
                System.out.println("La conexion no fue realizada");
                return null;
            }
        } catch (ClassNotFoundException | SQLException e) {
            e.printStackTrace();
        }
        return conexion;
    }

    /**
     * Metodo encargado de cerrar la conexion con la base de datos.
     * @throws java.sql.SQLException
     */
    public void cerrarConexionBD() throws SQLException {
        if (conexion != null && !conexion.isClosed()) {
            conexion.close();
        }
    }

}
