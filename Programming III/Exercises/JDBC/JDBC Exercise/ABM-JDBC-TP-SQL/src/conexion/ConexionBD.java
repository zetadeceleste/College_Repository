package conexion;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Jeremias Reyes
 */
public class ConexionBD {

    Connection conexion = null;

    /**
     * Metodo encargado de abrir una conexion con la base de datos.
     *
     * @return Devuelve un objeto de tipo Connection.
     */
    public Connection abrirConexionBD() {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            String urlConexion = "jdbc:mysql://localhost:3306/tp-jdbc-sql";
            conexion = DriverManager.getConnection(urlConexion, "root", "");
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
     * Metodo que cierra la conexion con la base de datos.
     *
     * @throws java.sql.SQLException
     */
    public void cerrarConexionBD() throws SQLException {
        if (conexion != null && !conexion.isClosed()) {
            conexion.close();
        }
    }

}
