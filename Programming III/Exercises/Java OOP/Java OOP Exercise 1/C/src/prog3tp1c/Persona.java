
package prog3tp1c;

import java.util.List;

public class Persona {
    private char nombre;
    private char tipoDocumento;
    private long nroDocumento;
    private int telefono;
    private char email;
    private char celular;
    private List<Actividad> actividades;
    private Sector sector;

    public char getNombre() {
        return nombre;
    }

    public void setNombre(char nombre) {
        this.nombre = nombre;
    }

    public char getTipoDocumento() {
        return tipoDocumento;
    }

    public void setTipoDocumento(char tipoDocumento) {
        this.tipoDocumento = tipoDocumento;
    }

    public long getNroDocumento() {
        return nroDocumento;
    }

    public void setNroDocumento(long nroDocumento) {
        this.nroDocumento = nroDocumento;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    public char getEmail() {
        return email;
    }

    public void setEmail(char email) {
        this.email = email;
    }

    public char getCelular() {
        return celular;
    }

    public void setCelular(char celular) {
        this.celular = celular;
    }

    public List<Actividad> getActividades() {
        return actividades;
    }

    public void setActividades(List<Actividad> actividades) {
        this.actividades = actividades;
    }

    public Sector getSector() {
        return sector;
    }

    public void setSector(Sector sector) {
        this.sector = sector;
    }
    
    public double totalPuntosAsignados(long nroDocumento){
        double puntos = 0;
        
        for (Actividad actividad : actividades) {
            puntos += actividad.getTipoActividad().getPuntosAsignados();
        }   
        
        return puntos;
    }
    
    public double totalPuntosAsignados(long nroDocumento, int codigo){
        double puntos = 0;
        
        for (Actividad actividad : actividades) {
            if (actividad.getTipoActividad().getCodigo() == codigo) {
                puntos += actividad.getTipoActividad().getPuntosAsignados();
            }
        }       
        
        return puntos;
    }
    
    public double totalPuntosAsignados(long nroDocumento, int codigo, int anio){
        double puntos = 0;

        for (Actividad actividad : actividades) {
            if (actividad.getTipoActividad().getCodigo() == codigo && actividad.getFechaInicio().getYear() == anio) {
                puntos += actividad.getTipoActividad().getPuntosAsignados();
            }
        }      
        
        return puntos;
    }
    
}
