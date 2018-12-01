package modelo;

import conexion.ConexionBD;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.SQLException;
import javax.swing.table.DefaultTableModel;
import vista.FrameConsulta;

/**
 * Clase encargada del modelo de las Consultas
 * @author Jeremias Reyes
 */
public final class ConsultaSQL extends ConexionBD {

    private String host;
    private int puerto;
    private String nombreBD;
    private String usuario;
    private String clave;
    private String query;

    public String getHost() {
        return host;
    }

    public void setHost(String host) {
        this.host = host;
    }

    public int getPuerto() {
        return puerto;
    }

    public void setPuerto(int puerto) {
        this.puerto = puerto;
    }

    public String getNombreBD() {
        return nombreBD;
    }

    public void setNombreBD(String nombreBD) {
        this.nombreBD = nombreBD;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getClave() {
        return clave;
    }

    public void setClave(String clave) {
        this.clave = clave;
    }

    public String getQuery() {
        return query;
    }

    public void setQuery(String query) {
        this.query = query;
    }

    /**
     * Metodo encargado de ejecutar las consultas.
     * @param conexion Conexion con para hacer la consulta.
     * @param frameConsulta JFrame encargado de la vista.
     * @param consultaSQL Estructura de la consulta a realizar.
     * @throws java.sql.SQLException
     */
    public void ejecutarConsulta(Connection conexion, FrameConsulta frameConsulta, ConsultaSQL consultaSQL) throws SQLException {
        PreparedStatement consulta = conexion.prepareStatement(consultaSQL.getQuery());
        if (!consultaSQL.getQuery().contains("SELECT")) {
            consulta.executeUpdate();
            System.out.println("La operacion fue exitosa");
        } else {
            DefaultTableModel modelo = new DefaultTableModel();
            frameConsulta.getTblResultados().setModel(modelo);
            ResultSet resultado = consulta.executeQuery();
            ResultSetMetaData rsMd = resultado.getMetaData();
            int cantidadColumnas = rsMd.getColumnCount();

            for (int i = 0; i < cantidadColumnas; i++) {
                modelo.addColumn(rsMd.getColumnName(i + 1));
            }

            while (resultado.next()) {
                Object filas[] = new Object[cantidadColumnas];

                for (int i = 0; i < cantidadColumnas; i++) {
                    filas[i] = resultado.getObject(i + 1);
                }
                modelo.addRow(filas);

            }

            System.out.println("La operacion fue exitosa");

        }
    }

}
