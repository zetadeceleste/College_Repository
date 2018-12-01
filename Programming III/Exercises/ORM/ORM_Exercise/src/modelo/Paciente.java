
package modelo;

import java.util.List;
import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@Entity
//Al heredar de Persona, se le define su tipo a nivel de base de datos
@DiscriminatorValue(value="Paciente")
public class Paciente extends Persona {
    private int idPaciente;
    private int nroSocio;
    private HistoriaClinica historiaClinica;
    private List<Turno> turnos;

    public Paciente(){
    }
    
    public int getIdPaciente() {
        return idPaciente;
    }

    public void setIdPaciente(int idPaciente) {
        this.idPaciente = idPaciente;
    }

    public int getNroSocio() {
        return nroSocio;
    }

    public void setNroSocio(int nroSocio) {
        this.nroSocio = nroSocio;
    } 
    
    //Relación: oneToOne un Paciente tiene una HistoriaClinica
    @OneToOne(cascade={CascadeType.ALL})
    @JoinColumn(name = "idHistoriaClinica")

    public HistoriaClinica getHistoriaClinica() {
        return historiaClinica;
    }

    public void setHistoriaClinica(HistoriaClinica historiaClinica) {
        this.historiaClinica = historiaClinica;
    }
    
    //Relación: oneToMany un Paciente puede tener varios Turnos
    @OneToMany(mappedBy = "paciente", cascade = CascadeType.ALL)

    public List<Turno> getTurnos() {
        return turnos;
    }

    public void setTurnos(List<Turno> turnos) {
        this.turnos = turnos;
    }
    
}
