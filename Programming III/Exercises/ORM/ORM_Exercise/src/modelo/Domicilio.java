
package modelo;

import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@Entity
public class Domicilio extends EntityBean implements java.io.Serializable {
    
    private int idDomicilio;
    private String localidad;
    private String calle;
    private int numero;
    private Persona persona;
    
    public Domicilio(){ 
    }

    public int getIdDomicilio() {
        return idDomicilio;
    }

    public void setIdDomicilio(int idDomicilio) {
        this.idDomicilio = idDomicilio;
    }

    public String getLocalidad() {
        return localidad;
    }

    public void setLocalidad(String localidad) {
        this.localidad = localidad;
    }

    public String getCalle() {
        return calle;
    }

    public void setCalle(String calle) {
        this.calle = calle;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    //Relación: oneToOne un Domicilio tiene una Persona
    
    @OneToOne(cascade={CascadeType.ALL})
    @JoinColumn(name = "idPersona")
    
    public Persona getPersona() {
        return persona;
    }

    public void setPersona(Persona persona) {
        this.persona = persona;
    }
    
}
