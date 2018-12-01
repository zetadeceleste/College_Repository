package controlador;

import java.util.List;
import org.hibernate.*;
import org.hibernate.type.StandardBasicTypes;
import persistencia.ConfigHibernate;

public class Gestor {
    protected String message = null;
    protected int firstResult;
    protected int maxResult = 50;
    protected long totalResult;
    protected int activePage;
    protected String order = "asc";
    private static ConfigHibernate configHibernate;
    protected List<String> packages;
    protected List<Class> clases;
    protected Session sesion;

    public Gestor() {
        configHibernate = new ConfigHibernate();
    }

    public void guardar(Object o) throws Exception {
        boolean guardar = false;
        Transaction tx = null;
        
        try {
            if (!sesion.getTransaction().isActive()) {
                tx = sesion.beginTransaction();
                guardar = true;
            }
            sesion.saveOrUpdate(o);
            if (guardar) {
                tx.commit();
                System.out.println("Objeto persistido.");
            }
        } catch (Exception e) {
            if (guardar) {
                tx.rollback();
            }
            throw new Exception(e.getMessage());
        }
    }

    public void guardarLista(List objetos) throws Exception {
        boolean guardar = false;
        Transaction tx = null;
        
        try {
            if (!sesion.getTransaction().isActive()) {
                tx = sesion.beginTransaction();
                guardar = true;
            }
            for (Object o : objetos) {
                guardar(o);
            }
            if (guardar) {
                tx.commit();
            }
        } catch (Exception e) {
            if (guardar) {
                tx.rollback();
            }
            throw new Exception(e.getMessage());
        }
    }

    public Object buscarPorId(Class clase, Long id) {
        Query consulta = sesion.createQuery("from " + clase.getSimpleName() + " a where a.id =" + id.toString());
        List<Object> lista;
        
        try {
            lista = consulta.list();
            if (lista.size() < 1) {
                return null;
            }
            if (lista.size() > 1) {
                return null;
            }
        } catch (RuntimeException e) {
            e.printStackTrace();
            return null;
        }
        Object[] x = lista.toArray();
        return x[0];
    }

    public List<Object> buscarPorAtributo(Session session, Class clase, String nombreAtributo, Object valorAtributo) throws Exception {
        Query consulta = session.createQuery("from " + clase.getSimpleName() + " entidad where entidad." + nombreAtributo + " =:valor");
        // en vez de utilizar Hibernate.STRING de la versión 3, se utiliza StandardBasicTypes.STRING
        consulta.setParameter("valor", valorAtributo, StandardBasicTypes.STRING);
        List<Object> lista;
        
        try {
            lista = consulta.list();
            return lista;
        } catch (RuntimeException e) {
            e.printStackTrace();
            throw new Exception(e.getMessage());
        }
    }

    public Object buscarObjetoPorAtributo(Session session, Class clase, String nombreAtributo, Object valorAtributo) throws Exception {
        Query consulta = session.createQuery("from " + clase.getSimpleName() + " entidad where entidad." + nombreAtributo + " =:valor");
        consulta.setParameter("valor", valorAtributo);
        List<Object> lista;
            
        try {
            lista = consulta.list();
            if (lista.size() == 1) {
                return lista.iterator().next();
            } else if (lista.size() == 0) {
                return null;
            } else {
                throw new Exception();
            }
        } catch (RuntimeException e) {
            e.printStackTrace();
            throw new Exception(e.getMessage());
        }
    }

    public List buscarPorAtributo(Class clase, String nombreAtributo, Object valorAtributo) {
        Query consulta = sesion.createQuery("from " + clase.getSimpleName() + " entidad where entidad." + nombreAtributo + " =:valor");
        consulta.setParameter("valor", valorAtributo);
        List<Object> lista;
        
        try {
            lista = consulta.list();
            return lista;
        } catch (RuntimeException e) {
            e.printStackTrace();
            return null;
        }
    }

    public Object buscarObjetoPorAtributo(Class clase, String nombreAtributo, Object valorAtributo) {
        Query consulta = sesion.createQuery("from " + clase.getSimpleName() + " entidad where entidad." + nombreAtributo + " =:valor");
        consulta.setParameter("valor", valorAtributo);
        List<Object> lista;
        
        try {
            lista = consulta.list();
            if (lista.size() > 0) {
                return lista.get(0);
            } else {
                return null;
            }
        } catch (RuntimeException e) {
            e.printStackTrace();
            return null;
        }
    }

    public List listar(Session session, Class clase) throws Exception {
        Query consulta = session.createQuery("from " + clase.getSimpleName() + " a");
        List<Object> lista;
        
        try {
            lista = consulta.list();
        } catch (RuntimeException e) {
            e.printStackTrace();
            throw new Exception();
        }
        if (lista == null) {
            throw new Exception();
        }
        return lista;
    }

    public List listar(Class clase) throws Exception {
        Query consulta = sesion.createQuery("from " + clase.getSimpleName() + " a");
        List<Object> lista;
        
        try {
            lista = consulta.list();
        } catch (RuntimeException e) {
            e.printStackTrace();
            throw new Exception();
        }
        if (lista == null) {
            throw new Exception();
        }
        return lista;
    }

    public void eliminar(Object o) throws Exception {
        boolean eliminar = false;
        Transaction tx = null;
        
        try {
            if (!sesion.getTransaction().isActive()) {
                tx = sesion.beginTransaction();
                eliminar = true;
            }
            sesion.delete(o);
            if (eliminar) {
                tx.commit();
            }
            System.out.println("objeto eliminado.");
        } catch (Exception e) {
            if (eliminar) {
                tx.rollback();
            }
            throw new Exception(e.getMessage());
        }
    }

    public ConfigHibernate getHu() {
        if (configHibernate != null) {
            return configHibernate;
        } else {
            configHibernate = new ConfigHibernate();
            return configHibernate;
        }
    }

    public static void setHu(ConfigHibernate configHibernate) {
        Gestor.configHibernate = configHibernate;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public void setMessage(String message, boolean error) {
        if (error) {
            this.setMessage("DGE: " + message);
        }
    }

    public void setFirstResult(int firstResult) {
        this.firstResult = firstResult;
    }

    public int getFirstResultActive() {
        return this.maxResult * (this.activePage - 1);
    }

    public int getMaxResult() {
        return maxResult;
    }

    public void setMaxResult(int maxResult) {
        this.maxResult = maxResult;
    }

    public long getTotalResult() {
        return totalResult;
    }

    public void setTotalResult(long totalResult) {
        this.totalResult = totalResult;
    }

    public int getTotalPages() {
        return Math.round((float) (this.totalResult + 0.1) / (float) this.maxResult);
    }

    public int getActivePage() {
        return activePage;
    }

    public void setActivePage(int activePage) {
        this.activePage = activePage;
    }

    public void setAscOrder() {
        this.order = "asc";
    }

    public void setDescOrder() {
        this.order = "desc";
    }

    public Session getSesion() {
        return sesion;
    }

    public void setSesion(Session sesion) {
        this.sesion = sesion;
    }
}
