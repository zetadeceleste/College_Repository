
package prog3tp1c;

import java.util.List;

public class Sector {
    private int numero;
    private String denominacion;
    private String tipo;
    private List<Sector> sectores;
    private List<Sector> sectoresHijos;
    private List<Persona> personas;

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public String getDenominacion() {
        return denominacion;
    }

    public void setDenominacion(String denominacion) {
        this.denominacion = denominacion;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public List<Sector> getSectores() {
        return sectores;
    }

    public void setSectores(List<Sector> sectores) {
        this.sectores = sectores;
    }

    public List<Sector> getSectoresHijos() {
        return sectoresHijos;
    }

    public void setSectoresHijos(List<Sector> sectoresHijos) {
        this.sectoresHijos = sectoresHijos;
    }

    public List<Persona> getPersonas() {
        return personas;
    }

    public void setPersonas(List<Persona> personas) {
        this.personas = personas;
    }

    public List<Sector> obtenerTotalSubsectores(Sector sector, List<Sector> sectores) {
        sectores.add(sector);
        if (sector.getSectoresHijos() != null) {
            for (Sector sectoresHijo : this.getSectoresHijos()) {
                System.out.println(sectoresHijo.getDenominacion());
                obtenerTotalSubsectores(sectoresHijo, sectores);
            }
        }

        return sectores;
    }
}
