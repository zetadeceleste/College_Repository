package consultasSQL;

import conexion.ConexionBD;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import modelo.Domicilio;

/**
 *
 * @author Celeste Zapata
 */
public class DomicilioSQL {

    /**
     * Metodo para insertar un domicilio en la base de datos.
     *
     * @param domicilio Domicilio que se va a insertar en la BD
     * @return Devuelve un entero de tipo long correspondiente al id, clave
     * primaria de la tabla Domicilio, y clave foranea en la tabla Empresa
     * @throws java.sql.SQLException Lanza una excepcion de tipo SQLException
     */
    public long insertarDomicilio(Domicilio domicilio) throws SQLException {
        long idUltimoDomicilio = 1;
        ConexionBD conexionBD = new ConexionBD();
        Connection conexion = conexionBD.abrirConexionBD();
        PreparedStatement consulta = conexion.prepareStatement("INSERT INTO domicilio (calle,numero,distrito) VALUES (?,?,?)", Statement.RETURN_GENERATED_KEYS);
        consulta.setString(1, domicilio.getCalle());
        consulta.setInt(2, domicilio.getNumero());
        consulta.setString(3, domicilio.getCalle());
        consulta.executeUpdate();
        ResultSet generatedKeys = consulta.getGeneratedKeys();
        if (generatedKeys.next()) {
            idUltimoDomicilio = generatedKeys.getLong(1);
        }
        conexionBD.cerrarConexionBD();
        return idUltimoDomicilio;

    }

    /**
     * Metodo para actualizar un domicilio en la base de datos.
     * 
     * @param domicilio Domicilio a actualizar.
     * @param conexion Conexion
     * @throws java.sql.SQLException lanza esta excepcion en caso de producirse
     * un error.
     */
    public void actualizarDomicilio(Domicilio domicilio, Connection conexion) throws SQLException {
        //ConexionBD conexionBD = new ConexionBD();
        //Connection conexion = conexionBD.abrirConexionBD();
        PreparedStatement consulta = conexion.prepareStatement("UPDATE domicilio SET calle = ?, numero = ?, distrito = ? WHERE id = ?");
        consulta.setString(1, domicilio.getCalle());
        consulta.setInt(2, domicilio.getNumero());
        consulta.setString(3, domicilio.getDistrito());
        consulta.setLong(4, domicilio.getId());
        consulta.executeUpdate();
        //conexionBD.cerrarConexionBD();
    }

    /**
     * Metodo para eliminar un domicilio de la base de datos.
     * 
     * @param domicilio Domicilio a eliminar
     * @param conexion La conexion con la cual se esta trabajando
     * @throws java.sql.SQLException lanza una excepcion de este tipo
     */
    public void eliminarDomicilio(Domicilio domicilio, Connection conexion) throws SQLException {
        PreparedStatement consulta = conexion.prepareStatement("DELETE FROM domicilio WHERE id = ?");
        consulta.setLong(1, domicilio.getId());
        consulta.executeUpdate();
    }

    /**
     * Metodo para consultar un domicilio según su id, en la base de datos.
     * 
     * @param id del domicilio
     * @return Devuelve una lista con los domicilios
     * @throws java.sql.SQLException
     */
    public Domicilio consultarDomicilio(long id) throws SQLException {          //Revisar este metodo
        Domicilio domicilio = new Domicilio();
        ConexionBD conexionBD = new ConexionBD();
        Connection conexion = conexionBD.abrirConexionBD();
        PreparedStatement consulta = conexion.prepareStatement("SELECT * FROM domicilio WHERE id = ?");
        consulta.setLong(1, id);
        ResultSet resultadoSQL = consulta.executeQuery();
        if (resultadoSQL.next()) {
            domicilio.setCalle(resultadoSQL.getString("calle"));
            domicilio.setDistrito(resultadoSQL.getString("distrito"));
            domicilio.setId(resultadoSQL.getLong("id"));
            domicilio.setNumero(resultadoSQL.getInt("numero"));
        }

        conexionBD.cerrarConexionBD();
        return domicilio;
    }

   

}
