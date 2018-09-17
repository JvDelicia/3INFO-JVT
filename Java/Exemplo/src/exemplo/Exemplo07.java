package exemplo;

import java.awt.*;
import java.text.NumberFormat;
import javax.swing.JFrame;
import javax.swing.JRootPane;
import javax.swing.JTextField;

public class Exemplo07 extends JFrame{
    JTextField t1, t2, t3;
    double v1 = 1000.54;
    int v2 = 100;
    NumberFormat df1, df2;
    public static void main(String[]args){
        JFrame j1 = new Exemplo07();
            j1.setUndecorated(true);
            j1.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
            j1.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            j1.setVisible(true);
    }
    Exemplo07(){
        setTitle("Formatação");
        setBounds(230,50,350,65);
        getContentPane().setBackground(new Color (0,0,255));
        getContentPane().setLayout(new GridLayout(1,2));
        df1 = NumberFormat.getNumberInstance();
        df1.setMinimumFractionDigits(4);
        df2 = NumberFormat.getNumberInstance();
        df2.setMinimumFractionDigits(2);
        t1 = new JTextField();
        t2 = new JTextField();
        t1.setText(" " + df1.format(v1));
        t2.setText(" " + df2.format(v2));
        getContentPane().add(t1);
        getContentPane().add(t2);
        
    }
}
