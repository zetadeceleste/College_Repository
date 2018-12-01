package main;

import controlador.ControladorFrame;
import javax.swing.JFrame;
import vista.FrameConsulta;

/**
 *
 * @author Jeremias Reyes
 */
public class ConexionJDBC {

    public static void main(String[] args) {
        FrameConsulta frameConsulta = new FrameConsulta();
        ControladorFrame controladorFrame = new ControladorFrame(frameConsulta);
        frameConsulta.setVisible(true);
        frameConsulta.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

}
