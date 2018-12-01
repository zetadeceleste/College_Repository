
package composicion;

import java.util.List;

/**
 *
 * @author celes
 */
public class Cliente {
    private String denominacion;
    private String cuit;
    private Domicilio domicilio;
    private List<Factura> facturas;

    public Cliente() {
        this.domicilio = new Domicilio();
    }

    public String getDenominacion() {
        return denominacion;
    }

    public void setDenominacion(String denominacion) {
        this.denominacion = denominacion;
    }

    public String getCuit() {
        return cuit;
    }

    public void setCuit(String cuit) {
        this.cuit = cuit;
    }

    public Domicilio getDomicilio() {
        return domicilio;
    }

    public void setDomicilio(Domicilio domicilio) {
        this.domicilio = domicilio;
    }

    public List<Factura> getFacturas() {
        return facturas;
    }

    public void setFacturas(List<Factura> facturas) {
        this.facturas = facturas;
    }

}
