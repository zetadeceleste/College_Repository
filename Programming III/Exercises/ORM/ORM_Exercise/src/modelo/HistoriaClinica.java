
package modelo;

import java.sql.Date;
import java.util.List;
import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@Entity
public class HistoriaClinica extends EntityBean implements java.io.Serializable {
    private int idHistoriaClinica;
    private int numero;
    private Date fechaAlta;
    private Paciente paciente;
    private List<DetalleHistoriaClinica> detallesHC;
    
    public HistoriaClinica(){
    }

    public int getIdHistoriaClinica() {
        return idHistoriaClinica;
    }

    public void setIdHistoriaClinica(int idHistoriaClinica) {
        this.idHistoriaClinica = idHistoriaClinica;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public Date getFechaAlta() {
        return fechaAlta;
    }

    public void setFechaAlta(Date fechaAlta) {
        this.fechaAlta = fechaAlta;
    }

    //Relación: oneToOne una HistoriaClinica tiene un Paciente
    @OneToOne(cascade={CascadeType.ALL})
    @JoinColumn(name = "idPaciente")
    
    public Paciente getPaciente() {
        return paciente;
    }

    public void setPaciente(Paciente paciente) {
        this.paciente = paciente;
    }

    //Relación: oneToMany una HistoriaClinica puede tener varios DetalleHistoriaClinica
    @OneToMany(mappedBy = "historiaClinica", cascade = CascadeType.ALL)
    
    public List<DetalleHistoriaClinica> getDetallesHC() {
        return detallesHC;
    }

    public void setDetallesHC(List<DetalleHistoriaClinica> detallesHC) {
        this.detallesHC = detallesHC;
    }
    
}
