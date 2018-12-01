package parcial1_programacion3;

import java.util.List;

/**
 *
 * @author Celeste Zapata
 */
public class DivisionCurso {

    private int codigo;
    private int anio;
    private int division;
    private Escuela escuela;
    private List<Catedra> catedras;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public int getAnio() {
        return anio;
    }

    public void setAnio(int anio) {
        this.anio = anio;
    }

    public int getDivision() {
        return division;
    }

    public void setDivision(int division) {
        this.division = division;
    }

    public Escuela getEscuela() {
        return escuela;
    }

    public void setEscuela(Escuela escuela) {
        this.escuela = escuela;
    }

    public List<Catedra> getCatedras() {
        return catedras;
    }

    public void setCatedras(List<Catedra> catedras) {
        this.catedras = catedras;
    }

    //Método solicitado en A.4
    public Alumno mejorAlumnoDivisionCurso() {
        Alumno mejorAlumnoDivision = null;
        boolean noRecupero;

        try {
            //Reutilizar método de Alumno de promedio de notas y comparar entre cátedras hasta obtener el mejor alumno de la división
            if (this.catedras != null) {
                for (Catedra catedra : catedras) {
                    for (Alumno alumno : catedra.getAlumnos()) {
                        noRecupero = true;
                        for (Nota nota : alumno.getNotas()) {
                            if (nota.isEsRecuperatorio()) {
                                noRecupero = false;
                            }
                        }
                        if (noRecupero && alumno.getNotas().size() >= 5) {
                            if (mejorAlumnoDivision == null || alumno.promedioNotas(null) > mejorAlumnoDivision.promedioNotas(null)) {
                                mejorAlumnoDivision = alumno;
                            }
                        }
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }
        return mejorAlumnoDivision;
    }
}
