
package modelo;

import java.sql.Date;
import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@Entity
public class DetalleHistoriaClinica extends EntityBean implements java.io.Serializable {
    private int idDetalleHC;
    private Date fechaAtencion;
    private String sintomas;
    private String diagnostico;
    private String observaciones;
    private HistoriaClinica historiaClinica;

    public DetalleHistoriaClinica(){
    }
    
    public int getIdDetalleHC() {
        return idDetalleHC;
    }

    public void setIdDetalleHC(int idDetalleHC) {
        this.idDetalleHC = idDetalleHC;
    }

    public Date getFechaAtencion() {
        return fechaAtencion;
    }

    public void setFechaAtencion(Date fechaAtencion) {
        this.fechaAtencion = fechaAtencion;
    }

    public String getSintomas() {
        return sintomas;
    }

    public void setSintomas(String sintomas) {
        this.sintomas = sintomas;
    }

    public String getDiagnostico() {
        return diagnostico;
    }

    public void setDiagnostico(String diagnostico) {
        this.diagnostico = diagnostico;
    }

    public String getObservaciones() {
        return observaciones;
    }

    public void setObservaciones(String observaciones) {
        this.observaciones = observaciones;
    }

    // Relación: manyToOne muchos DetalleHistoriaClínica tienen una HistoriaClínica
    @ManyToOne(cascade = CascadeType.ALL)
    @JoinColumn(name = "idHistoriaClinica")
    
    public HistoriaClinica getHistoriaClinica() {
        return historiaClinica;
    }

    public void setHistoriaClinica(HistoriaClinica historiaClinica) {
        this.historiaClinica = historiaClinica;
    }
    
}
