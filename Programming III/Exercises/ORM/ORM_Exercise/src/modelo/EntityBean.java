
package modelo;

import java.io.Serializable;
import javax.persistence.*;

/**
 *
 * @author Celeste Zapata
 */

@MappedSuperclass
@Inheritance(strategy = InheritanceType.JOINED) 

public abstract class EntityBean implements Serializable {
    
    protected Long id;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public static String getIdentityPropery() {
        return "id";
    }
}
