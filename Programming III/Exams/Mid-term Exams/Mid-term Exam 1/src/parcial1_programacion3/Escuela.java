package parcial1_programacion3;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

/**
 *
 * @author Celeste Zapata
 */
public class Escuela {

    private int numero;
    private String denominacion;
    private List<DivisionCurso> divisiones;

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public String getDenominacion() {
        return denominacion;
    }

    public void setDenominacion(String denominacion) {
        this.denominacion = denominacion;
    }

    public List<DivisionCurso> getDivisiones() {
        return divisiones;
    }

    public void setDivisiones(List<DivisionCurso> divisiones) {
        this.divisiones = divisiones;
    }

    // Método solicitado en A.5
    public Alumno getMejorAlumnoEscuela(int anioNacimientoAlumno) {
        Alumno mejorAlumnoEscuela = null;
        boolean noDesaprobo;

        try {
            //Obtener un List de alumnos que no hayan desaprobado y comparar promedios hasta llegar al mejor alumno
            if (this.divisiones != null) {
                for (DivisionCurso division : divisiones) {
                    noDesaprobo = true;
                    for (Nota nota : division.mejorAlumnoDivisionCurso().getNotas()) {
                        if (nota.getValor() < 4) {
                            noDesaprobo = false;
                        }
                    }
                    if (noDesaprobo) {
                        if (division.mejorAlumnoDivisionCurso().getFechaNacimiento().getYear() == anioNacimientoAlumno) {
                            if (mejorAlumnoEscuela == null || division.mejorAlumnoDivisionCurso().promedioNotas(null) > mejorAlumnoEscuela.promedioNotas(null)) {
                                mejorAlumnoEscuela = division.mejorAlumnoDivisionCurso();
                            }
                        }
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }
        return mejorAlumnoEscuela;
    }

// Método solicitado en A.6
    public List<Alumno> getMejoresAlumnos(int anioNacimientoAlumno) {
        List<Alumno> listaAlumnos = new ArrayList<>();
        List<Alumno> mejoresAlumnos = new ArrayList<>();
        boolean noDesaprobo;

        try {
            //Obtener un List de alumnos que no hayan desaprobado
            if (this.divisiones != null) {
                for (DivisionCurso division : divisiones) {
                    for (Catedra catedra : division.getCatedras()) {
                        for (Alumno alumno : catedra.getAlumnos()) {
                            noDesaprobo = true;
                            for (Nota nota : alumno.getNotas()) {
                                if (nota.getValor() < 4) {
                                    noDesaprobo = false;
                                }
                            }
                            if (noDesaprobo) {
                                if (alumno.getFechaNacimiento().getYear() == anioNacimientoAlumno) {
                                    listaAlumnos.add(alumno);
                                }
                            }
                        }
                    }
                }
            }
            //Eliminar duplicados en el List
            Set<Alumno> hs = new HashSet<>();
            hs.addAll(listaAlumnos);
            listaAlumnos.clear();
            listaAlumnos.addAll(hs);

            //Ubicar los 3 mejores promedios en un nuevo List
            for (Alumno alumno1 : listaAlumnos) {
                for (Alumno alumno2 : listaAlumnos) {
                    if (alumno1.promedioNotas(null) < alumno2.promedioNotas(null)) {
                        if (mejoresAlumnos.size() < 3) {
                            mejoresAlumnos.add(alumno2);
                        }
                    }
                }
            }
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }
        return mejoresAlumnos;
    }
}
