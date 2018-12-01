
package tp_orm;

import controlador.*;
import modelo.*;

/**
 *
 * @author Celeste Zapata
 */

public class Main {

    public static void main(String[] args) {
        try {
            GestorEmpleado gestorEmpleado = new GestorEmpleado();
            DetalleHistoriaClinica detalleHC = new DetalleHistoriaClinica();
            Domicilio domicilio = new Domicilio();
            Empleado empleado = new Empleado();
            Especialidad especialidad = new Especialidad();
            HistoriaClinica historiaClinica = new HistoriaClinica();
            Medico medico = new Medico();
            Paciente paciente = new Paciente();
            Turno turno = new Turno();
            
            empleado.setNombre("lala");
            empleado.setApellido("Zapata");
            empleado.setDni(3456);
            empleado.setNroLegajo(4354);
            empleado.setSueldo(22000.00);
            
            gestorEmpleado.guardar(empleado);
            empleado.toString();
            
        } catch (Exception e) {
            e.printStackTrace();
        }
        
        
    }
    
}
