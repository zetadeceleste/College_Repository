package consultasSQL;

import conexion.ConexionBD;
import funciones.FuncionApp;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;
import modelo.Domicilio;
import modelo.Empresa;

/**
 *
 * @author Celeste Zapata
 */
public class EmpresaSQL {

    /**
     * Metodo para evaluar si una empresa ingresada es valida o no.
     *
     * @param empresa a evaluar
     * @return true si la empresa es valida y false en caso contrario.
     * @throws java.sql.SQLException
     */
    public boolean esEmpresaValida(Empresa empresa) throws SQLException {
        if (empresa.getCuit() == 0) {
            System.out.println("El cuit de la empresa es obligatorio");
        }
        Empresa empresaXBusqueda = seleccionarEmpresaPorCuit(empresa.getCuit());
        if (empresaXBusqueda != null) {
            System.out.println("La empresa que desea ingresar ya esta registrada en la base de datos");
            return false;
        }
        if (FuncionApp.fechaMayorHoy(empresa.getFechaAlta())) {
            System.out.println("La fecha en la que se dio de alta debe ser menor que la fecha actual");
            return false;
        }
        if (empresa.getDomicilio().getCalle() == null || empresa.getDomicilio().getDistrito() == null
                || empresa.getDomicilio().getNumero() == 0) {
            System.out.println("Se deben ingresar todos los valores del domicilio de la empresa");
        }

        return true;
    }

    /**
     * Metodo para insertar una Empresa en la base de datos
     *
     * @param empresa Empresa a eliminar
     * @throws java.sql.SQLException Lanza una excepcion
     */
    public void insertarEmpresa(Empresa empresa) throws SQLException {
        ConexionBD conexionBD = new ConexionBD();
        Connection conexion = conexionBD.abrirConexionBD();
        DomicilioSQL domicilioSQL = new DomicilioSQL();
        long idDomicilio = domicilioSQL.insertarDomicilio(empresa.getDomicilio());
        PreparedStatement consulta = conexion.prepareStatement("INSERT INTO empresa (cuit,razonSocial,condicionIVA,deudaActual,fechaAlta,idDomicilio) VALUES (?,?,?,?,?,?)");
        consulta.setLong(1, empresa.getCuit());
        consulta.setString(2, empresa.getRazonSocial());
        consulta.setString(3, empresa.getCondicionIVA());
        consulta.setDouble(4, empresa.getDeudaActual());
        consulta.setDate(5, FuncionApp.datoUtilToDateSQL(empresa.getFechaAlta()));

        if (empresa.getDomicilio() != null) {
            consulta.setLong(6, idDomicilio);
        } else {
            consulta.setObject(6, null);
        }

        consulta.executeUpdate();
        conexionBD.cerrarConexionBD();
    }

    /**
     * Metodo para actualizar una empresa en la base de datos
     *
     * @param empresa Empresa a actualizar
     * @throws java.sql.SQLException lanza una excepcion
     */
    public void actualizarEmpresa(Empresa empresa) throws SQLException {
        ConexionBD conexionBD = new ConexionBD();
        Connection conexion = conexionBD.abrirConexionBD();
        DomicilioSQL domicilioSQL = new DomicilioSQL();
        domicilioSQL.actualizarDomicilio(empresa.getDomicilio(), conexion);
        PreparedStatement consulta = conexion.prepareStatement("UPDATE empresa SET razonSocial = ?, condicionIVA = ? WHERE cuit = ? ");
        consulta.setString(1, empresa.getRazonSocial());
        consulta.setString(2, empresa.getCondicionIVA());
        consulta.setLong(3, empresa.getCuit());
        consulta.executeUpdate();
        conexionBD.cerrarConexionBD();
    }

    /**
     * Metodo para eliminar una empresa en la base de datos.
     *
     * @param empresa Empresa a eliminar
     * @throws java.sql.SQLException lannza una excepcion de este tipo
     */
    public void eliminarEmpresa(Empresa empresa) throws SQLException {
        ConexionBD conexionBD = new ConexionBD();
        Connection conexion = conexionBD.abrirConexionBD();
        conexion.setAutoCommit(false);
        DomicilioSQL domicilioSQL = new DomicilioSQL();
        try {
            PreparedStatement consulta = conexion.prepareStatement("DELETE FROM empresa WHERE cuit = ?");
            consulta.setLong(1, empresa.getCuit());
            consulta.executeUpdate();
            domicilioSQL.eliminarDomicilio(empresa.getDomicilio(), conexion);
            conexion.commit();
        } catch (SQLException e) {
            conexion.rollback();
            System.out.println("La operacion no pudo completarse exitosamente");
            e.printStackTrace();
        } finally {
            conexionBD.cerrarConexionBD();
        }

    }

    /**
     * Metodo para consultar la tabla empresa en la base de datos.
     *
     * @throws java.sql.SQLException
     */
    public void consultarEmpresa() throws SQLException {
        ConexionBD conexionBD = new ConexionBD();
        Connection conexion = conexionBD.abrirConexionBD();
        DomicilioSQL domicilioSQL = new DomicilioSQL();
        Domicilio domicilio;
        PreparedStatement consulta = conexion.prepareStatement("SELECT * FROM empresa");
        ResultSet resultadoSQL = consulta.executeQuery();
        while (resultadoSQL.next()) {
            System.out.println("------------------------------------------------------------");
            System.out.println("Cuit: " + resultadoSQL.getLong("cuit"));
            System.out.println("Razon Social: " + resultadoSQL.getString("razonSocial"));
            System.out.println("Condicion IVA: " + resultadoSQL.getString("condicionIVA"));
            System.out.println("deudaActual: " + resultadoSQL.getDouble("deudaActual"));
            System.out.println("fechaAlta: " + resultadoSQL.getDate("fechaAlta"));
            domicilio = domicilioSQL.consultarDomicilio(resultadoSQL.getLong("idDomicilio"));
            System.out.println("Id domicilio: " + domicilio.getId());
            System.out.println("Calle: " + domicilio.getCalle());
            System.out.println("Numero: " + domicilio.getNumero());
            System.out.println("Distrito: " + domicilio.getDistrito());
        }
        conexionBD.cerrarConexionBD();
    }

    /**
     * Metodo para cargar los datos de la empresa que va a ser ingresada y es no
     * existe en la base de datos.
     *
     * @param empresa empresa a cargar
     * @return Devuelve una empresa con sus datos cargados
     * @throws java.sql.SQLException
     */
    public Empresa cargarDatosEmpresaNueva(Empresa empresa) throws SQLException {
        do {
            System.out.println("Ingrese la informacion de la empresa");
            Scanner ingreso = new Scanner(System.in);
            System.out.println("Cuit de la empresa");
            long cuit = Long.parseLong(ingreso.nextLine());     //Validar
            System.out.println("Razon Social");
            ingreso = new Scanner(System.in);
            String razonSocial = ingreso.nextLine();
            System.out.println("Condicion IVA RI(RESPONSABLE INSCRIPTO), AR(AGENTE DE RETENCION), MON(MONOTRIBUTISTA)");
            ingreso = new Scanner(System.in);
            String condicionIVA = ingreso.nextLine();
            System.out.println("Deuda actual");
            ingreso = new Scanner(System.in);
            double deudaActual = Double.parseDouble(ingreso.nextLine());
            System.out.println("Fecha Alta con formato dd-mm-yyyy");
            ingreso = new Scanner(System.in);
            String fechaAlta = ingreso.nextLine();
            System.out.println("Ingrese la calle del domicilio de la empresa: ");
            ingreso = new Scanner(System.in);
            String calle = ingreso.nextLine();
            System.out.println("Ingrese el numero del domicilio de la empresa: ");
            ingreso = new Scanner(System.in);
            int numero = Integer.parseInt(ingreso.nextLine());
            System.out.println("Ingrese el distrito del domicilio de la empresa: ");
            ingreso = new Scanner(System.in);
            String distrito = ingreso.nextLine();

            empresa.setCuit(cuit);
            empresa.setRazonSocial(razonSocial);
            empresa.setCondicionIVA(condicionIVA);
            empresa.setDeudaActual(deudaActual);
            empresa.setFechaAlta(FuncionApp.convertirStringToDate(fechaAlta));
            empresa.setDomicilio(new Domicilio());
            empresa.getDomicilio().setCalle(calle);
            empresa.getDomicilio().setNumero(numero);
            empresa.getDomicilio().setDistrito(distrito);

            if (esEmpresaValida(empresa)) {
                return empresa;
            } else {
                System.out.println("Desea intentar cargar nuevamente la empresa? Y/N");
                ingreso = new Scanner(System.in);
                String respuesta = ingreso.nextLine();
                if (respuesta.equals("N")) {
                    return null;
                }
            }
        } while (true);
    }

    /**
     * Metodo para cargar los datos de una empresa que existe en la base de
     * datos.
     *
     * @param empresa a ingresar
     * @return devuelve la empresa con sus datos.
     * @throws java.sql.SQLException
     */
    public Empresa cargarDatosEmpresaExistente(Empresa empresa) throws SQLException {
        System.out.println("Cuit de la empresa");
        Scanner ingreso = new Scanner(System.in);
        long cuit = Long.parseLong(ingreso.nextLine());     //Validar
        Empresa empresaBusqueda = seleccionarEmpresaPorCuit(cuit);
        if (empresaBusqueda != null) {
            System.out.println("Razon Social: ");
            ingreso = new Scanner(System.in);
            String razonSocial = ingreso.nextLine();

            System.out.println("Condicion IVA RI(RESPONSABLE INSCRIPTO), AR(AGENTE DE RETENCION), MON(MONOTRIBUTISTA)");
            ingreso = new Scanner(System.in);
            String condicionIVA = ingreso.nextLine();

            System.out.println("Ingrese la calle del domicilio de la empresa: ");
            ingreso = new Scanner(System.in);
            String calle = ingreso.nextLine();

            System.out.println("Ingrese el numero del domicilio de la empresa: ");
            ingreso = new Scanner(System.in);
            int numero = Integer.parseInt(ingreso.nextLine());

            System.out.println("Ingrese el distrito del domicilio de la empresa: ");
            ingreso = new Scanner(System.in);
            String distrito = ingreso.nextLine();

            empresa.setRazonSocial(razonSocial);
            empresa.setCondicionIVA(condicionIVA);
            empresa.setCuit(cuit);
            empresa.setDomicilio(empresaBusqueda.getDomicilio());
            empresa.getDomicilio().setCalle(calle);
            empresa.getDomicilio().setNumero(numero);
            empresa.getDomicilio().setDistrito(distrito);
            return empresa;
        } else {
            return null;
        }

    }

    /**
     * Metodo para obtener una empresa por su cuit de la base de datos.
     *
     * @param cuit de la empresa
     * @return devuelve una empresa
     * @throws java.sql.SQLException
     */
    public Empresa seleccionarEmpresaPorCuit(long cuit) throws SQLException {
        ConexionBD conexionBD = new ConexionBD();
        Connection conexion = conexionBD.abrirConexionBD();
        PreparedStatement consulta = conexion.prepareStatement("SELECT * FROM empresa WHERE cuit = ?");
        consulta.setLong(1, cuit);
        ResultSet resultadoSQL = consulta.executeQuery();
        Empresa empresa = null;
        DomicilioSQL domicilioSQL = new DomicilioSQL();
        if (resultadoSQL.next()) {
            empresa = new Empresa();
            empresa.setDeudaActual(resultadoSQL.getDouble("deudaActual"));
            empresa.setRazonSocial(resultadoSQL.getString("razonSocial"));
            empresa.setFechaAlta(resultadoSQL.getDate("fechaAlta"));
            empresa.setCuit(resultadoSQL.getLong("cuit"));
            empresa.setCondicionIVA(resultadoSQL.getString("condicionIVA"));
            empresa.setDomicilio(domicilioSQL.consultarDomicilio(resultadoSQL.getLong("idDomicilio")));

        }
        return empresa;
    }

}
