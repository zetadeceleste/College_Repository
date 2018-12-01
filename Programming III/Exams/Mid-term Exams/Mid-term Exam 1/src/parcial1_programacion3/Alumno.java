package parcial1_programacion3;

import java.util.Date;
import java.util.List;

/**
 *
 * @author Celeste Zapata
 */
public class Alumno {

    private long legajo;
    private String nombre;
    private String apellido;
    private Date fechaNacimiento;
    private Catedra catedra;
    private List<Nota> notas;

    public long getLegajo() {
        return legajo;
    }

    public void setLegajo(long legajo) {
        this.legajo = legajo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Date fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }

    public Catedra getCatedra() {
        return catedra;
    }

    public void setCatedra(Catedra catedra) {
        this.catedra = catedra;
    }

    public List<Nota> getNotas() {
        return notas;
    }

    public void setNotas(List<Nota> notas) {
        this.notas = notas;
    }

    //Método solicitado en A.1
    public Nota mejorNota(Integer codigoCatedra) {
        Nota mejorNota = null;

        try {
            //Chequear la mejor nota sin que sea recuperatorio, de acuerdo (o no) al código de cátedra
            if (this.notas != null) {
                for (Nota nota : this.notas) {
                    if (codigoCatedra == null) {
                        if (!(nota.isEsRecuperatorio()) && (mejorNota == null || nota.getValor() >= mejorNota.getValor())) {
                            mejorNota = nota;
                        }
                    } else if (!(nota.isEsRecuperatorio()) && (nota.getCatedra().getCodigo() == codigoCatedra)) {
                        if (mejorNota == null || nota.getValor() >= mejorNota.getValor()) {
                            mejorNota = nota;
                        }
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }
        return mejorNota;
    }

    //Método solicitado en A.2
    public double promedioNotas(Integer codigoCatedra) {
        double total = 0;
        int contador = 0;
        double promedio;

        try {
            //Ver todas las notas (de no recuperatorios) y obtener el promedio de acuerdo (o no) al código de cátedra
            if (this.notas != null) {
                for (Nota nota : this.notas) {
                    if (!(nota.isEsRecuperatorio()) && codigoCatedra == null) {
                        total += nota.getValor();
                        contador++;
                    } else if (!(nota.isEsRecuperatorio()) && (nota.getCatedra().getCodigo() == codigoCatedra)) {
                        total += nota.getValor();
                        contador++;
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }
        promedio = (total / contador);
        return promedio;
    }
}
