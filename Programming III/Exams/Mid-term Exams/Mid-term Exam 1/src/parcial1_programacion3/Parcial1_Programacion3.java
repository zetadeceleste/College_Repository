package parcial1_programacion3;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

/**
 *
 * @author Celeste Zapata
 */
public class Parcial1_Programacion3 {

    public static void main(String[] args) throws ParseException {
        //Divisiones
        DivisionCurso divisionA = new DivisionCurso();
        divisionA.setCodigo(1);
        DivisionCurso divisionB = new DivisionCurso();
        divisionB.setCodigo(2);
        List<DivisionCurso> divisiones = new ArrayList<>();
        divisiones.add(divisionA);
        divisiones.add(divisionB);

        //Escuela
        Escuela escuelaValleDeGuantata = new Escuela();
        escuelaValleDeGuantata.setDivisiones(divisiones);

        //Cátedras Division A
        List<Catedra> catedrasDivisionA = new ArrayList<>();
        Catedra matematica = new Catedra();
        matematica.setCodigo(11);
        Catedra biologia = new Catedra();
        biologia.setCodigo(12);
        catedrasDivisionA.add(matematica);
        catedrasDivisionA.add(biologia);

        //Cátedras Division B
        List<Catedra> catedrasDivisionB = new ArrayList<>();
        Catedra lengua = new Catedra();
        lengua.setCodigo(21);
        Catedra cssociales = new Catedra();
        cssociales.setCodigo(22);
        catedrasDivisionB.add(lengua);
        catedrasDivisionB.add(cssociales);

        //Notas Alumno1: Celeste Division A / Me: 6, 2 recuperatorios
        Nota nota1Alumno11 = new Nota();
        nota1Alumno11.setCatedra(matematica);
        nota1Alumno11.setValor(6);
        nota1Alumno11.setEsRecuperatorio(false);
        Nota nota2Alumno11 = new Nota();
        nota2Alumno11.setCatedra(matematica);
        nota2Alumno11.setValor(6);
        nota2Alumno11.setEsRecuperatorio(false);
        Nota nota3Alumno11 = new Nota();
        nota3Alumno11.setCatedra(matematica);
        nota3Alumno11.setValor(6);
        nota3Alumno11.setEsRecuperatorio(false);
        Nota nota4Alumno11 = new Nota();
        nota4Alumno11.setCatedra(biologia);
        nota4Alumno11.setValor(6);
        nota4Alumno11.setEsRecuperatorio(true);
        Nota nota5Alumno11 = new Nota();
        nota5Alumno11.setCatedra(biologia);
        nota5Alumno11.setValor(6);
        nota5Alumno11.setEsRecuperatorio(false);
        Nota nota6Alumno11 = new Nota();
        nota6Alumno11.setCatedra(biologia);
        nota6Alumno11.setValor(6);
        nota6Alumno11.setEsRecuperatorio(true);
        List<Nota> notasAlumno11 = new ArrayList<>();
        notasAlumno11.add(nota1Alumno11);
        notasAlumno11.add(nota2Alumno11);
        notasAlumno11.add(nota3Alumno11);
        notasAlumno11.add(nota4Alumno11);
        notasAlumno11.add(nota5Alumno11);
        notasAlumno11.add(nota6Alumno11);

        //Notas Alumno2: Vanesa Division A / Me: 10, 1 recuperatorio
        Nota nota1Alumno12 = new Nota();
        nota1Alumno12.setCatedra(matematica);
        nota1Alumno12.setValor(10);
        nota1Alumno12.setEsRecuperatorio(false);
        Nota nota2Alumno12 = new Nota();
        nota2Alumno12.setCatedra(matematica);
        nota2Alumno12.setValor(10);
        nota2Alumno12.setEsRecuperatorio(true);
        Nota nota3Alumno12 = new Nota();
        nota3Alumno12.setCatedra(matematica);
        nota3Alumno12.setValor(10);
        nota3Alumno12.setEsRecuperatorio(false);
        Nota nota4Alumno12 = new Nota();
        nota4Alumno12.setCatedra(biologia);
        nota4Alumno12.setValor(10);
        nota4Alumno12.setEsRecuperatorio(false);
        Nota nota5Alumno12 = new Nota();
        nota5Alumno12.setCatedra(biologia);
        nota5Alumno12.setValor(10);
        nota5Alumno12.setEsRecuperatorio(false);
        Nota nota6Alumno12 = new Nota();
        nota6Alumno12.setCatedra(biologia);
        nota6Alumno12.setValor(10);
        nota6Alumno12.setEsRecuperatorio(false);
        List<Nota> notasAlumno12 = new ArrayList<>();
        notasAlumno12.add(nota1Alumno12);
        notasAlumno12.add(nota2Alumno12);
        notasAlumno12.add(nota3Alumno12);
        notasAlumno12.add(nota4Alumno12);
        notasAlumno12.add(nota5Alumno12);
        notasAlumno12.add(nota6Alumno12);

        //Notas Alumno3: Damian Division A / Me: 1, 0 recuperatorios
        Nota nota1Alumno13 = new Nota();
        nota1Alumno13.setCatedra(matematica);
        nota1Alumno13.setValor(1);
        nota1Alumno13.setEsRecuperatorio(false);
        Nota nota2Alumno13 = new Nota();
        nota2Alumno13.setCatedra(matematica);
        nota2Alumno13.setValor(1);
        nota2Alumno13.setEsRecuperatorio(false);
        Nota nota3Alumno13 = new Nota();
        nota3Alumno13.setCatedra(matematica);
        nota3Alumno13.setValor(1);
        nota3Alumno13.setEsRecuperatorio(false);
        Nota nota4Alumno13 = new Nota();
        nota4Alumno13.setCatedra(biologia);
        nota4Alumno13.setValor(1);
        nota4Alumno13.setEsRecuperatorio(false);
        Nota nota5Alumno13 = new Nota();
        nota5Alumno13.setCatedra(biologia);
        nota5Alumno13.setValor(1);
        nota5Alumno13.setEsRecuperatorio(false);
        Nota nota6Alumno13 = new Nota();
        nota6Alumno13.setCatedra(biologia);
        nota6Alumno13.setValor(1);
        nota6Alumno13.setEsRecuperatorio(false);
        List<Nota> notasAlumno13 = new ArrayList<>();
        notasAlumno13.add(nota1Alumno13);
        notasAlumno13.add(nota2Alumno13);
        notasAlumno13.add(nota3Alumno13);
        notasAlumno13.add(nota4Alumno13);
        notasAlumno13.add(nota5Alumno13);
        notasAlumno13.add(nota6Alumno13);

        //Alumnos Division A Datos
        Alumno alumno11 = new Alumno();
        alumno11.setNombre("Celeste");
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        String fecha11 = "1989-03-12";
        Date fechaNacimiento11 = sdf.parse(fecha11);
        alumno11.setFechaNacimiento(fechaNacimiento11);
        alumno11.setNotas(notasAlumno11);
        Alumno alumno12 = new Alumno();
        alumno12.setNombre("Vanesa");
        String fecha12 = "1989-04-01";
        Date fechaNacimiento12 = sdf.parse(fecha12);
        alumno12.setFechaNacimiento(fechaNacimiento12);
        alumno12.setNotas(notasAlumno12);
        Alumno alumno13 = new Alumno();
        alumno13.setNombre("Damian");
        String fecha13 = "1989-07-11";
        Date fechaNacimiento13 = sdf.parse(fecha13);
        alumno13.setFechaNacimiento(fechaNacimiento13);
        alumno13.setNotas(notasAlumno13);

        List<Alumno> alumnosDivisionA = new ArrayList<>();
        alumnosDivisionA.add(alumno11);
        alumnosDivisionA.add(alumno12);
        alumnosDivisionA.add(alumno13);
        matematica.setAlumnos(alumnosDivisionA);
        matematica.setDivision(divisionA);
        biologia.setAlumnos(alumnosDivisionA);
        biologia.setDivision(divisionA);
        divisionA.setCatedras(catedrasDivisionA);

        //Notas Alumno1: Renzo Division B / Me: 4, 2 recuperatorios
        Nota nota1Alumno21 = new Nota();
        nota1Alumno21.setCatedra(lengua);
        nota1Alumno21.setValor(4);
        nota1Alumno21.setEsRecuperatorio(false);
        Nota nota2Alumno21 = new Nota();
        nota2Alumno21.setCatedra(lengua);
        nota2Alumno21.setValor(4);
        nota2Alumno21.setEsRecuperatorio(false);
        Nota nota3Alumno21 = new Nota();
        nota3Alumno21.setCatedra(lengua);
        nota3Alumno21.setValor(4);
        nota3Alumno21.setEsRecuperatorio(false);
        Nota nota4Alumno21 = new Nota();
        nota4Alumno21.setCatedra(cssociales);
        nota4Alumno21.setValor(4);
        nota4Alumno21.setEsRecuperatorio(true);
        Nota nota5Alumno21 = new Nota();
        nota5Alumno21.setCatedra(cssociales);
        nota5Alumno21.setValor(4);
        nota5Alumno21.setEsRecuperatorio(false);
        Nota nota6Alumno21 = new Nota();
        nota6Alumno21.setCatedra(cssociales);
        nota6Alumno21.setValor(4);
        nota6Alumno21.setEsRecuperatorio(true);
        List<Nota> notasAlumno21 = new ArrayList<>();
        notasAlumno21.add(nota1Alumno21);
        notasAlumno21.add(nota2Alumno21);
        notasAlumno21.add(nota3Alumno21);
        notasAlumno21.add(nota4Alumno21);
        notasAlumno21.add(nota5Alumno21);
        notasAlumno21.add(nota6Alumno21);

        //Notas Alumno2: Luz Division B / Me: 10, 0 recuperatorios
        Nota nota1Alumno22 = new Nota();
        nota1Alumno22.setCatedra(lengua);
        nota1Alumno22.setValor(10);
        nota1Alumno22.setEsRecuperatorio(false);
        Nota nota2Alumno22 = new Nota();
        nota2Alumno22.setCatedra(lengua);
        nota2Alumno22.setValor(10);
        nota2Alumno22.setEsRecuperatorio(false);
        Nota nota3Alumno22 = new Nota();
        nota3Alumno22.setCatedra(lengua);
        nota3Alumno22.setValor(10);
        nota3Alumno22.setEsRecuperatorio(false);
        Nota nota4Alumno22 = new Nota();
        nota4Alumno22.setCatedra(cssociales);
        nota4Alumno22.setValor(10);
        nota4Alumno22.setEsRecuperatorio(false);
        Nota nota5Alumno22 = new Nota();
        nota5Alumno22.setCatedra(cssociales);
        nota5Alumno22.setValor(10);
        nota5Alumno22.setEsRecuperatorio(false);
        Nota nota6Alumno22 = new Nota();
        nota6Alumno22.setCatedra(cssociales);
        nota6Alumno22.setValor(10);
        nota6Alumno22.setEsRecuperatorio(false);
        List<Nota> notasAlumno22 = new ArrayList<>();
        notasAlumno22.add(nota1Alumno22);
        notasAlumno22.add(nota2Alumno22);
        notasAlumno22.add(nota3Alumno22);
        notasAlumno22.add(nota4Alumno22);
        notasAlumno22.add(nota5Alumno22);
        notasAlumno22.add(nota6Alumno22);

        //Notas Alumno3: Andy Division B / Me: 7, 0 recuperatorios
        Nota nota1Alumno23 = new Nota();
        nota1Alumno23.setCatedra(lengua);
        nota1Alumno23.setValor(7);
        nota1Alumno23.setEsRecuperatorio(false);
        Nota nota2Alumno23 = new Nota();
        nota2Alumno23.setCatedra(lengua);
        nota2Alumno23.setValor(7);
        nota2Alumno23.setEsRecuperatorio(false);
        Nota nota3Alumno23 = new Nota();
        nota3Alumno23.setCatedra(lengua);
        nota3Alumno23.setValor(7);
        nota3Alumno23.setEsRecuperatorio(false);
        Nota nota4Alumno23 = new Nota();
        nota4Alumno23.setCatedra(cssociales);
        nota4Alumno23.setValor(7);
        nota4Alumno23.setEsRecuperatorio(false);
        Nota nota5Alumno23 = new Nota();
        nota5Alumno23.setCatedra(cssociales);
        nota5Alumno23.setValor(7);
        nota5Alumno23.setEsRecuperatorio(false);
        Nota nota6Alumno23 = new Nota();
        nota6Alumno23.setCatedra(cssociales);
        nota6Alumno23.setValor(7);
        nota6Alumno23.setEsRecuperatorio(false);
        List<Nota> notasAlumno23 = new ArrayList<>();
        notasAlumno23.add(nota1Alumno23);
        notasAlumno23.add(nota2Alumno23);
        notasAlumno23.add(nota3Alumno23);
        notasAlumno23.add(nota4Alumno23);
        notasAlumno23.add(nota5Alumno23);
        notasAlumno23.add(nota6Alumno23);

        //Alumnos Division B Datos
        Alumno alumno21 = new Alumno();
        alumno21.setNombre("Renzo");
        String fecha21 = "1989-04-11";
        Date fechaNacimiento21 = sdf.parse(fecha21);
        alumno21.setFechaNacimiento(fechaNacimiento21);
        alumno21.setNotas(notasAlumno21);
        Alumno alumno22 = new Alumno();
        alumno22.setNombre("Luz");
        String fecha22 = "1989-12-17";
        Date fechaNacimiento22 = sdf.parse(fecha22);
        alumno22.setFechaNacimiento(fechaNacimiento22);
        alumno22.setNotas(notasAlumno22);
        Alumno alumno23 = new Alumno();
        alumno23.setNombre("Andy");
        String fecha23 = "1989-08-21";
        Date fechaNacimiento23 = sdf.parse(fecha23);
        alumno23.setFechaNacimiento(fechaNacimiento23);
        alumno23.setNotas(notasAlumno23);

        List<Alumno> alumnosDivisionB = new ArrayList<>();
        alumnosDivisionB.add(alumno21);
        alumnosDivisionB.add(alumno22);
        alumnosDivisionB.add(alumno23);
        lengua.setAlumnos(alumnosDivisionB);
        lengua.setDivision(divisionB);
        cssociales.setAlumnos(alumnosDivisionB);
        cssociales.setDivision(divisionB);
        divisionB.setCatedras(catedrasDivisionB);

        //Pruebas de Métodos
        try {
            //A.1
            Nota notaPrueba;
            notaPrueba = alumno11.mejorNota(null);
            System.out.println("Mejor nota de " + alumno11.getNombre() + " " + notaPrueba.getValor());
            notaPrueba = alumno12.mejorNota(null);
            System.out.println("Mejor nota de " + alumno12.getNombre() + " " + notaPrueba.getValor());
            notaPrueba = alumno13.mejorNota(null);
            System.out.println("Mejor nota de " + alumno13.getNombre() + " " + notaPrueba.getValor());
            notaPrueba = alumno21.mejorNota(null);
            System.out.println("Mejor nota de " + alumno21.getNombre() + " " + notaPrueba.getValor());
            notaPrueba = alumno22.mejorNota(null);
            System.out.println("Mejor nota de " + alumno22.getNombre() + " " + notaPrueba.getValor());
            notaPrueba = alumno23.mejorNota(null);
            System.out.println("Mejor nota de " + alumno23.getNombre() + " " + notaPrueba.getValor());

            //A.2
            double promedio;
            promedio = alumno11.promedioNotas(11);
            System.out.println("Promedio de " + alumno11.getNombre() + " en Matemática: " + promedio);
            promedio = alumno11.promedioNotas(12);
            System.out.println("Promedio de " + alumno11.getNombre() + " en Biología: " + promedio);
            promedio = alumno12.promedioNotas(11);
            System.out.println("Promedio de " + alumno12.getNombre() + " en Matemática: " + promedio);
            promedio = alumno12.promedioNotas(12);
            System.out.println("Promedio de " + alumno12.getNombre() + " en Biología: " + promedio);
            promedio = alumno13.promedioNotas(11);
            System.out.println("Promedio de " + alumno13.getNombre() + " en Matemática: " + promedio);
            promedio = alumno13.promedioNotas(12);
            System.out.println("Promedio de " + alumno13.getNombre() + " en Biología: " + promedio);
            promedio = alumno21.promedioNotas(21);
            System.out.println("Promedio de " + alumno21.getNombre() + " en Lengua: " + promedio);
            promedio = alumno21.promedioNotas(22);
            System.out.println("Promedio de " + alumno21.getNombre() + " en Ciencias Sociales: " + promedio);
            promedio = alumno22.promedioNotas(21);
            System.out.println("Promedio de " + alumno22.getNombre() + " en Lengua: " + promedio);
            promedio = alumno22.promedioNotas(22);
            System.out.println("Promedio de " + alumno22.getNombre() + " en Ciencias Sociales: " + promedio);
            promedio = alumno23.promedioNotas(21);
            System.out.println("Promedio de " + alumno23.getNombre() + " en Lengua: " + promedio);
            promedio = alumno23.promedioNotas(22);
            System.out.println("Promedio de " + alumno23.getNombre() + " en Ciencias Sociales: " + promedio);

            //A.3
            Alumno alumnoPrueba;
            alumnoPrueba = matematica.mejorAlumnoCatedra();
            System.out.println("Mejor alumno/a de Matemática: " + alumnoPrueba.getNombre());
            alumnoPrueba = biologia.mejorAlumnoCatedra();
            System.out.println("Mejor alumno/a de Biología: " + alumnoPrueba.getNombre());
            alumnoPrueba = lengua.mejorAlumnoCatedra();
            System.out.println("Mejor alumno/a de Lengua: " + alumnoPrueba.getNombre());
            alumnoPrueba = cssociales.mejorAlumnoCatedra();
            System.out.println("Mejor alumno/a de Ciencias Sociales: " + alumnoPrueba.getNombre());

            //A.4
            alumnoPrueba = divisionA.mejorAlumnoDivisionCurso();
            System.out.println("Mejor alumno/a División A: " + alumnoPrueba.getNombre());
            alumnoPrueba = divisionB.mejorAlumnoDivisionCurso();
            System.out.println("Mejor alumno/a División B: " + alumnoPrueba.getNombre());

            //A.5
            alumnoPrueba = escuelaValleDeGuantata.getMejorAlumnoEscuela(89);
            System.out.println("Mejor alumno/a de la Escuela: " + alumnoPrueba.getNombre());

            //A.6
            List<Alumno> alumnosPrueba;
            alumnosPrueba = escuelaValleDeGuantata.getMejoresAlumnos(89);
            System.out.println("Mejores alumnos/as de la Escuela:");
            alumnosPrueba.forEach((alumno) -> {
                System.out.println(alumno.getNombre());
            });

        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
        }

    }
}
