
package prog3tp1c;

import java.util.List;

public class TipoActividad {
    private int codigo;
    private char denominacion;
    private double puntosAsignados;
    private List<Actividad> actividades;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public char getDenominacion() {
        return denominacion;
    }

    public void setDenominacion(char denominacion) {
        this.denominacion = denominacion;
    }

    public double getPuntosAsignados() {
        return puntosAsignados;
    }

    public void setPuntosAsignados(double puntosAsignados) {
        this.puntosAsignados = puntosAsignados;
    }

    public List<Actividad> getActividades() {
        return actividades;
    }

    public void setActividades(List<Actividad> actividades) {
        this.actividades = actividades;
    }
    
}
