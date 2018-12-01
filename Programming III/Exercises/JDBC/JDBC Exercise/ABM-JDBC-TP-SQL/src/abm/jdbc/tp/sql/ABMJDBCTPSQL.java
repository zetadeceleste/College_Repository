package abm.jdbc.tp.sql;
import consultasSQL.EmpresaSQL;
import java.sql.SQLException;
import java.util.Scanner;
import modelo.Domicilio;
import modelo.Empresa;

/**
 *
 * @author Jeremias Reyes
 */
public class ABMJDBCTPSQL {

    public static void main(String[] args) throws SQLException {
        menuSistema();
    }

    /**
     * Metodo encargado de manejar  el menu del sistema
     * @throws java.sql.SQLException
     */
    public static void menuSistema() throws SQLException {
        String opcionConsulta;
        Scanner entrada = new Scanner(System.in);
        Domicilio domicilio = new Domicilio();
        EmpresaSQL empresaSQL = new EmpresaSQL();
        Empresa empresa;
        do {
            System.out.println("Ingrese la opcion numerica que desee realizar: ");
            System.out.println("1.Insert empresa");
            System.out.println("2.Update empresa");
            System.out.println("3.Delete empresa");
            System.out.println("4.Select empresa");
            System.out.println("0.Salir");
            opcionConsulta = entrada.nextLine();

            switch (opcionConsulta) {
                case "1":
                    empresa = new Empresa();
                    empresa = empresaSQL.cargarDatosEmpresaNueva(empresa);   //Cargo los datos de la empresa.
                    if (empresa != null) {
                        empresaSQL.insertarEmpresa(empresa);
                    }
                    break;
                case "2":
                    empresa = new Empresa();
                    empresa = empresaSQL.cargarDatosEmpresaExistente(empresa);
                    if (empresa != null) {
                        empresaSQL.actualizarEmpresa(empresa);
                    }
                    else{
                        System.out.println("La empresa no pudo actualizarse");
                    }
                    break;
                case "3":
                    System.out.println("Ingrese el cuit de la empresa a eliminar: ");
                    entrada = new Scanner(System.in);
                    long cuit = Long.parseLong(entrada.nextLine());
                    empresa = empresaSQL.seleccionarEmpresaPorCuit(cuit);
                    if (empresa != null) {
                        empresaSQL.eliminarEmpresa(empresa);
                        System.out.println("La empresa fue eliminada junto con su domicilio");
                    }
                    else{
                        System.out.println("La empresa no pudo eliminarse");
                    }

                    break;
                case "4":
                    empresaSQL.consultarEmpresa();
                    break;
                case "0":
                    System.out.println("Sistema y conexion finalizado");
                    break;
                default:
                    System.out.println("La opcion ingresada no es correcta");
                    break;
            }
            System.out.println("----------------------------------");
        } while (!opcionConsulta.equals("0"));
    }

}
