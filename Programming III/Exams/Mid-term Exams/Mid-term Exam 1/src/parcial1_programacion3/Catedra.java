package parcial1_programacion3;

import java.util.List;

/**
 *
 * @author Celeste Zapata
 */
public class Catedra {

    private int codigo;
    private String denominacion;
    private DivisionCurso division;
    private List<Nota> notas;
    private List<Alumno> alumnos;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getDenominacion() {
        return denominacion;
    }

    public void setDenominacion(String denominacion) {
        this.denominacion = denominacion;
    }

    public DivisionCurso getDivision() {
        return division;
    }

    public void setDivision(DivisionCurso division) {
        this.division = division;
    }

    public List<Nota> getNotas() {
        return notas;
    }

    public void setNotas(List<Nota> notas) {
        this.notas = notas;
    }

    public List<Alumno> getAlumnos() {
        return alumnos;
    }

    public void setAlumnos(List<Alumno> alumnos) {
        this.alumnos = alumnos;
    }

    //Método solicitado en A.3
    public Alumno mejorAlumnoCatedra() {
        Alumno mejorAlumno = null;
        double promedio;

        try {
            //Reutilizar método de Alumno del promedio de notas y comparar con los demás para obtener el mejor alumno de la cátedra
            if (this.alumnos != null) {
                for (Alumno alumno : this.alumnos) {
                    promedio = alumno.promedioNotas(this.codigo);
                    if (mejorAlumno == null || promedio > mejorAlumno.promedioNotas(this.codigo)) {
                        mejorAlumno = alumno;
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }
        return mejorAlumno;
    }
}
