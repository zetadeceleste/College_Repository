
package modelo;

import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@Entity
//Al heredar de Persona, se le define su tipo a nivel de base de datos
@DiscriminatorValue("Empleado")
public class Empleado extends Persona {

    private int idEmpleado;
    private int nroLegajo;
    private double sueldo;

    public Empleado(){
    }
    
    public int getIdEmpleado() {
        return idEmpleado;
    }

    public void setIdEmpleado(int idEmpleado) {
        this.idEmpleado = idEmpleado;
    }

    public int getNroLegajo() {
        return nroLegajo;
    }

    public void setNroLegajo(int nroLegajo) {
        this.nroLegajo = nroLegajo;
    }

    public double getSueldo() {
        return sueldo;
    }

    public void setSueldo(double sueldo) {
        this.sueldo = sueldo;
    }
    
}
