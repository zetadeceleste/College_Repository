package controlador;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import modelo.ConsultaSQL;
import vista.FrameConsulta;

/**
 * Clase encargada de controlar la vista.
 * @author Celeste Zapata
 */
public class ControladorFrame implements ActionListener {

    private FrameConsulta frameConsulta = new FrameConsulta();
    private ConsultaSQL consultaSQL = new ConsultaSQL();

    public ControladorFrame(FrameConsulta frameConsulta) {
        this.frameConsulta = frameConsulta;
        this.frameConsulta.getBtnEjecutar().addActionListener(this);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource().equals(this.getFrameConsulta().getBtnEjecutar())) {
            try {
                consultaSQL.setHost(frameConsulta.getTxtHost().getText());
                consultaSQL.setPuerto(Integer.parseInt(frameConsulta.getTxtPuerto().getText()));
                consultaSQL.setNombreBD(frameConsulta.getTxtBaseDeDatos().getText());
                consultaSQL.setUsuario(frameConsulta.getTxtUsuario().getText());
                consultaSQL.setClave(frameConsulta.getTxtClave().getText());

                Connection conexion = consultaSQL.abrirConexionBD(consultaSQL.getHost(),
                        consultaSQL.getPuerto(),
                        consultaSQL.getNombreBD(),
                        consultaSQL.getUsuario(), consultaSQL.getClave());

                consultaSQL.setQuery(frameConsulta.getTxtAreaSql().getText());

                consultaSQL.ejecutarConsulta(conexion, frameConsulta, consultaSQL);

            } catch (Exception ex) {
                ex.printStackTrace();
            } finally {
                try {
                    consultaSQL.cerrarConexionBD();
                } catch (SQLException ex) {
                    Logger.getLogger(ControladorFrame.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    }

    public FrameConsulta getFrameConsulta() {
        return frameConsulta;
    }

    public void setFrameConsulta(FrameConsulta frameConsulta) {
        this.frameConsulta = frameConsulta;
    }

    public ConsultaSQL getConsultaSQL() {
        return consultaSQL;
    }

    public void setConsultaSQL(ConsultaSQL consultaSQL) {
        this.consultaSQL = consultaSQL;
    }

}
