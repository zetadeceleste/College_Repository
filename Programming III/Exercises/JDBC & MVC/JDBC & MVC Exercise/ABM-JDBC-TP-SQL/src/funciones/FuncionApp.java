package funciones;

import java.util.Calendar;
import java.util.Date;

/**
 *
 * @author Celeste Zapata
 */
public class FuncionApp {

    public static java.sql.Date datoUtilToDateSQL(Date fechaUtil) {
        java.sql.Date fechaSQL = new java.sql.Date(fechaUtil.getTime());
        return fechaSQL;
    }

    public static Date convertirStringToDate(String fecha) {
        String fechaAux = fecha.replaceAll("/", "-");
        String[] fechaArray = fechaAux.split("-");
        if (fechaArray.length == 3) {
            Date fechaDate = new Date((Integer.valueOf(fechaArray[2]) - 1900), (Integer.valueOf(fechaArray[1]) - 1), Integer.valueOf(fechaArray[0]));
            return fechaDate;
        }
        return null;
    }

    public static boolean fechaMayorHoy(Date fecha) {
        Calendar cal1 = Calendar.getInstance(); //declara cal1
        Calendar cal2 = Calendar.getInstance(); //declara cal2
        cal1.setTime(fecha); //applies date to cal1
        cal2.setTime(new Date());

        return cal1.after(cal2);
    }
}
