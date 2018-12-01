
package composicion;

import java.util.List;

/**
 *
 * @author celes
 */
public class Articulo {
    private int nombre;
    private double precio;
    private List<FacturaDetalle> facturaDetalles;

    public int getNombre() {
        return nombre;
    }

    public void setNombre(int nombre) {
        this.nombre = nombre;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public List<FacturaDetalle> getFacturaDetalles() {
        return facturaDetalles;
    }

    public void setFacturaDetalles(List<FacturaDetalle> facturaDetalles) {
        this.facturaDetalles = facturaDetalles;
    }

}
