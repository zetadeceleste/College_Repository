package prog3tp1d;

import java.util.List;

public class Vivienda {

    private long id;
    private String calle;
    private int numeroCalle;
    private double superficieTerreno;
    private Barrio barrio;
    private List<Habitacion> habitaciones;

    public List<Habitacion> getHabitaciones() {
        return habitaciones;
    }

    public void setHabitaciones(List<Habitacion> habitaciones) {
        this.habitaciones = habitaciones;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getCalle() {
        return calle;
    }

    public void setCalle(String calle) {
        this.calle = calle;
    }

    public int getNumeroCalle() {
        return numeroCalle;
    }

    public void setNumeroCalle(int numeroCalle) {
        this.numeroCalle = numeroCalle;
    }

    public double getSuperficieTerreno() {
        return superficieTerreno;
    }

    public void setSuperficieTerreno(double superficieTerreno) {
        this.superficieTerreno = superficieTerreno;
    }

    public Barrio getBarrio() {
        return barrio;
    }

    public void setBarrio(Barrio barrio) {
        this.barrio = barrio;
    }

    public double getMetrosCuadradosCubiertos() {
        double total = 0;

        for (Habitacion habitacion : this.getHabitaciones()) {
            total += habitacion.getMetrosCuadrados();
        }

        if (total > this.getSuperficieTerreno()) {
            try {
                throw new Exception("La superficie cubierta no puede ser mayor a la superficie del terreno");
            } catch (Exception ex) {
                ex.printStackTrace();
            }
        }
        return total;
    }
}
