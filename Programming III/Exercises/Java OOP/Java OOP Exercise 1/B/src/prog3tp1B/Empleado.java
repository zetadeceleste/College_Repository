
package prog3tp1B;

import java.util.ArrayList;
import java.util.List;

public class Empleado {
    
    private String nombre;
    private long cuit;
    private String domicilio;
    private String email;
    private List<Asistencia> asistencias;
    private List<Tardanza> tardanzas;
    private RegimenHorario regimenHorario;

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public long getCuit() {
        return cuit;
    }

    public void setCuit(long cuit) {
        this.cuit = cuit;
    }

    public String getDomicilio() {
        return domicilio;
    }

    public void setDomicilio(String domicilio) {
        this.domicilio = domicilio;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public List<Asistencia> getAsistencias() {
        return asistencias;
    }

    public void setAsistencias(List<Asistencia> asistencias) {
        this.asistencias = asistencias;
    }

    public List<Tardanza> getTardanzas() {
        return tardanzas;
    }

    public void setTardanzas(List<Tardanza> tardanzas) {
        this.tardanzas = tardanzas;
    }

    public RegimenHorario getRegimenHorario() {
        return regimenHorario;
    }

    public void setRegimenHorario(RegimenHorario regimenHorario) {
        this.regimenHorario = regimenHorario;
    }
    
    public List<Asistencia> getAsistenciasXMesXAnio(int mes, int anio){
        List<Asistencia> asistenciasXmesXAnio = new ArrayList<Asistencia>();
        
        if (this.asistencias != null ) {
            for (Asistencia asistencia : asistencias) {
                if (mes == asistencia.getFecha().getMonth() & anio == asistencia.getFecha().getYear()) {
                    asistenciasXmesXAnio.add(asistencia);
                }
            }
        }
        return asistenciasXmesXAnio;
    }
    
    public List<Tardanza> getDiasConTardanza(int mes, int anio){
        List<Tardanza> diasConTardanza = new ArrayList<Tardanza>();
        List<Asistencia> asistencias = getAsistenciasXMesXAnio(mes, anio);
        
        if(asistencias != null){
            for (Asistencia asistencia : asistencias) {
                if (asistencia.getHora() >= this.regimenHorario.getHoraIngreso() & asistencia.getHora() <= this.regimenHorario.getHoraEgreso()) {
                    if (asistencia.getHora() > this.regimenHorario.getHoraIngreso() || asistencia.getMinuto() > 15) {
                        Tardanza tardanza = new Tardanza();
                        tardanza.setHora(asistencia.getHora());
                        tardanza.setMinuto(asistencia.getMinuto());
                        diasConTardanza.add(tardanza);
                    }  
                }
            }
        }
        return diasConTardanza;
    }
        
}
