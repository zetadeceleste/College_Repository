
package composicion;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

/**
 *
 * @author celes
 */
public class Factura {
    private Date fecha;
    private long numero;
    private double total;
    private List<FacturaDetalle> facturaDetalles;

    public Factura() {
        this.facturaDetalles = new ArrayList<>();
    }
    
    public void agregarFacturaDetalle() {
        FacturaDetalle facturaDetalle = new FacturaDetalle();
        this.facturaDetalles.add(facturaDetalle);
    }
    
    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public long getNumero() {
        return numero;
    }

    public void setNumero(long numero) {
        this.numero = numero;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

}
