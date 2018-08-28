package Exercicios;

import java.awt.*;
import java.awt.event.*;
import java.util.Date;
import javax.swing.*;
import java.text.DecimalFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.*;

public class Exe11 extends JFrame implements ActionListener{
    JLabel l1,l2,l3,l4,l5,l6,l7,pergunta;
    JButton b1;
    JTextField t1;
    
    public static void main(String[] args) {
        JFrame janela = new Exe11();
        janela.setUndecorated(true);
        janela.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setVisible(true);
    }
    Exe11(){
        setTitle("Tempo vivido");
        setBounds(700,50,300,700);
        getContentPane().setBackground(new Color(91, 235, 210));
        getContentPane().setLayout(new GridLayout(10,1));
        

        
        b1 = new JButton("Achar");
        b1.addActionListener(this);     
        
        pergunta = new JLabel("pergunta");
        pergunta.setForeground(Color.black);
        pergunta.setFont(new Font("", Font.BOLD,14));
        pergunta.setText("Sua data de nascimento:");
        
        l1 = new JLabel("l1");
        l1.setForeground(Color.black);
        l1.setFont(new Font("", Font.BOLD,14));
        
        l2 = new JLabel("l2");
        l2.setForeground(Color.black);
        l2.setFont(new Font("", Font.BOLD,14));
        
        l3 = new JLabel("l3");
        l3.setForeground(Color.black);
        l3.setFont(new Font("", Font.BOLD,14));
        
        l4 = new JLabel("l4");
        l4.setForeground(Color.black);
        l4.setFont(new Font("", Font.BOLD,14));
        
        l5 = new JLabel("l5");
        l5.setForeground(Color.black);
        l5.setFont(new Font("", Font.BOLD,14));
        
        l6 = new JLabel("l6");
        l6.setForeground(Color.black);
        l6.setFont(new Font("", Font.BOLD,14));
        
        l7 = new JLabel("l7");
        l7.setForeground(Color.black);
        l7.setFont(new Font("", Font.BOLD,14));
        l7.setText("");

        
        t1 = new JTextField();
        
       add(pergunta);
       add(t1);
       add(b1);
       add(l1);
       add(l2);
       add(l3);
       add(l4);
       add(l5);
       add(l6);
       add(l7);
       l1.setText("");
       l2.setText("");
       l3.setText("");
       l4.setText("");
       l5.setText("");
       l6.setText("");
       l7.setText("");
       
    }
    public void actionPerformed(ActionEvent e) {
        if (e.getSource()==b1){
            
            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");     
            Date dataQualquer = new Date();
            Date dataNasc = null;
            
            try {
                dataNasc = sdf.parse(t1.getText());
            } catch (ParseException ex) {
                Logger.getLogger(Exe11.class.getName()).log(Level.SEVERE, null, ex);
            }
 
            long diferencaMS = dataQualquer.getTime() - dataNasc.getTime();
            long diferencaSegundos = diferencaMS / 1000;
            long diferencaMinutos = diferencaSegundos / 60;
            long diferencaHoras = diferencaMinutos / 60;
            long diferencaDias = diferencaHoras / 24;
            double diferencaMeses = diferencaDias/30.416;
            double diferencaAnos = diferencaMeses/12;
            
            l1.setText(diferencaMS + " milisegundos vividos");
            l2.setText(diferencaSegundos + " segundos vividos");
            l3.setText(diferencaMinutos + " minutos vividos");
            l4.setText(diferencaHoras + " horas vividas");
            l5.setText(diferencaDias + " dias vividos");
            l6.setText(String.format("%.1f",diferencaMeses)+ " meses vividos");
            l7.setText(String.format("%.1f", diferencaAnos) + " anos vividos");

            return;
        }
    }
}
