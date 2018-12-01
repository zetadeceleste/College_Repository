
package controlador;

import persistencia.ConfigHibernate;

/**
 *
 * @author Celeste Zapata
 */

public class GestorEmpleado extends Gestor {

    public GestorEmpleado() {
        sesion = ConfigHibernate.openSession();
    }
    
}
