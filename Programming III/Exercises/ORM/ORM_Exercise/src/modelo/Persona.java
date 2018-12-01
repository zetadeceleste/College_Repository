
package modelo;

import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@Entity
public class Persona extends EntityBean implements java.io.Serializable {
    
    private int idPersona;
    private String nombre;
    private String apellido;
    private long dni;
    private Domicilio domicilio;

    public Persona(){
    }
    
    public int getIdPersona() {
        return idPersona;
    }

    public void setIdPersona(int idPersona) {
        this.idPersona = idPersona;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public long getDni() {
        return dni;
    }

    public void setDni(long dni) {
        this.dni = dni;
    }

    //Relación: oneToOne una Persona tiene un Domicilio
    @OneToOne(cascade={CascadeType.ALL})
    @JoinColumn(name = "idDomicilio")
    
    public Domicilio getDomicilio() {
        return domicilio;
    }

    public void setDomicilio(Domicilio domicilio) {
        this.domicilio = domicilio;
    }
    
}
