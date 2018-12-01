
package modelo;

import java.sql.Date;
import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@Entity
public class Turno extends EntityBean implements java.io.Serializable {
    private int idTurno;
    private Date Fecha;
    private int hora;
    private int minutos;
    private Medico medico;
    private Paciente paciente;
    
    public Turno(){
    }

    public int getIdTurno() {
        return idTurno;
    }

    public void setIdTurno(int idTurno) {
        this.idTurno = idTurno;
    }

    public Date getFecha() {
        return Fecha;
    }

    public void setFecha(Date Fecha) {
        this.Fecha = Fecha;
    }

    public int getHora() {
        return hora;
    }

    public void setHora(int hora) {
        this.hora = hora;
    }

    public int getMinutos() {
        return minutos;
    }

    public void setMinutos(int minutos) {
        this.minutos = minutos;
    }

    // Relación: manyToOne muchos Turnos tienen un Médico
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "idMedico")
    
    public Medico getMedico() {
        return medico;
    }

    public void setMedico(Medico medico) {
        this.medico = medico;
    }

    // Relación: manyToOne muchos Turnos tienen un Paciente
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "idPaciente")
    
    public Paciente getPaciente() {
        return paciente;
    }

    public void setPaciente(Paciente paciente) {
        this.paciente = paciente;
    }
    
}
