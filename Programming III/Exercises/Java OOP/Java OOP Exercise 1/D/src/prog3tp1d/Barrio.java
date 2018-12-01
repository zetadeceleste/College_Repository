package prog3tp1d;

import java.util.List;

public class Barrio {

    private long id;
    private String nombre;
    private String empresaConstructora;
    private List<Vivienda> viviendas;

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getEmpresaConstructora() {
        return empresaConstructora;
    }

    public void setEmpresaConstructora(String empresaConstructora) {
        this.empresaConstructora = empresaConstructora;
    }

    public List<Vivienda> getViviendas() {
        return viviendas;
    }

    public void setViviendas(List<Vivienda> viviendas) {
        this.viviendas = viviendas;
    }

    public double getSuperficieTotalTerreno() {
        double total = 0;
        for (Vivienda vivienda : this.getViviendas()) {
            total += vivienda.getSuperficieTerreno();
        }
        return total;
    }

    public double getSuperficieTotalCubierta() {
        double total = 0;
        for (Vivienda vivienda : this.getViviendas()) {
            total += vivienda.getMetrosCuadradosCubiertos();
        }
        return total;
    }

}
