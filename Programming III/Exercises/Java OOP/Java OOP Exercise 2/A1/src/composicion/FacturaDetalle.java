
package composicion;

/**
 *
 * @author celes
 */
public class FacturaDetalle {
    private int cantidad;
    private Articulo articulo;
    private Factura factura;

    public FacturaDetalle() {
        this.factura = new Factura();
    }
    
    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public Articulo getArticulo() {
        return articulo;
    }

    public void setArticulo(Articulo articulo) {
        this.articulo = articulo;
    }
    
}
