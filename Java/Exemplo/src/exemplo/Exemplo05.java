package exemplo;

import java.awt.Color;
import javax.swing.JFrame;
import javax.swing.JRootPane;

public class Exemplo05 extends JFrame{
    Exemplo05(){
        setTitle("Janela Exemplo");
        setBounds(50,50,350,120);
        setResizable(true);
        getContentPane().setBackground(new Color(0,41,66));
    }
    
    public static void main(String[]args){
        JFrame janela = new Exemplo05();
        janela.setUndecorated(true);
        janela.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setVisible(true);
    }
}