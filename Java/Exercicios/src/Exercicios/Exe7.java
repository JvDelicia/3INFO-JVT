package Exercicios;

import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;
import javax.swing.*;

public class Exe7 extends JFrame implements ActionListener {
    JLabel l1, l2, l3, l4, l5, l6, l7,l8,l9,l10;
    JButton b1, b2, b3, b4, b5;
    JTextField t1, t2, t3,t4,t5,t6,t7,t8,t9,t10;   
    
    Exe7() {
        setTitle("Comodos");
        setBounds(600, 255, 400, 300);
        setResizable (true);
        getContentPane().setBackground(new Color(0, 90, 150));
        getContentPane().setLayout(new GridLayout(8,2));
       
        l1 = new JLabel("Nome do comodo");
        l1.setForeground(Color.black);
        l1.setFont(new Font("", Font.BOLD, 14));
        l2 = new JLabel("Largura:");
        l2.setForeground(Color.black);
        l2.setFont(new Font("", Font.BOLD, 14));
        l3 = new JLabel("Comprimento");
        l3.setForeground(Color.black);
        l3.setFont(new Font("", Font.BOLD, 14));
        l4 = new JLabel("Area do comodo:");
        l4.setForeground(Color.black);
        l4.setFont(new Font("", Font.BOLD, 14));
        l5 = new JLabel("Deseja continuar?");
        l5.setForeground(Color.black);
        l5.setFont(new Font("", Font.BOLD, 14));
        l6 = new JLabel("Area da casa");
        l6.setForeground(Color.black);
        l6.setFont(new Font("", Font.BOLD, 14));
        l7 = new JLabel("");
        l7.setForeground(Color.black);
        l7.setFont(new Font("", Font.BOLD, 14));
        
        b1 = new JButton("CALCULAR");
        b1.addActionListener(this); 
        b3 = new JButton("SIM");
        b3.setEnabled(false);
        b3.addActionListener(this); 
        b2 = new JButton("LIMPAR");
        b2.addActionListener(this);
        b2.setBackground(Color.black);
        b2.setForeground(Color.white);
        b4 = new JButton("NÃO");
        b4.setEnabled(false);
        b4.addActionListener(this);
        b4.setBackground(Color.black);
        b4.setForeground(Color.white);
        
        t1 = new JTextField();
        t1.setFont(new Font("", Font.BOLD, 22));
        t2 = new JTextField();
        t2.setFont(new Font("", Font.BOLD, 22));
        t3 = new JTextField();
        t3.setFont(new Font("", Font.BOLD, 22));
        t4 = new JTextField();
        t4.setFont(new Font("", Font.BOLD, 22));
        t4.setEnabled(false);
        t5 = new JTextField();
        t5.setFont(new Font("", Font.BOLD, 22));
        t5.setEnabled(false);
        
         getContentPane().add(l1);     
         getContentPane().add(t1);
         
         getContentPane().add(l2);
         getContentPane().add(t2);    
       
         getContentPane().add(l3);
         getContentPane().add(t3);
         
         getContentPane().add(b1);
         getContentPane().add(b2);
         
         getContentPane().add(l5);
         getContentPane().add(l7);
         
         getContentPane().add(b3);
         getContentPane().add(b4);
         
         getContentPane().add(l4);
         getContentPane().add(t4);
         
         getContentPane().add(l6);
         getContentPane().add(t5);
         
    }
      public static void main (String[]args){
        JFrame janela = new Exe7();
        janela.setUndecorated(true);
        janela.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setVisible(true);
    }
      public static double y=0;
      public void actionPerformed(ActionEvent e){
          double l=0, c=0, t=0;
        if (e.getSource() == b2){            
            t1.setText("");
            t2.setText(""); 
            t3.setText(""); 
            t4.setText(""); 
            t5.setText(""); 
            return;
        }
        try{
           
           l = Integer.parseInt(t2.getText());
           c = Integer.parseInt(t3.getText());
          
        }
        catch(NumberFormatException erro){
            t4.setText("Erro de conversão");
        }
        if (e.getSource() == b1){           
            l = Integer.parseInt(t2.getText());
            c = Integer.parseInt(t3.getText());
            t = l * c;
            t4.setText(""+t);
            y = y + t;
            t5.setText(""+y);
            b3.setEnabled(true);
            b4.setEnabled(true);
            b1.setEnabled(false);
            b2.setEnabled(false);
            return;            
        }
        if (e.getSource() == b3){            
            t1.setText("");
            t2.setText(""); 
            t3.setText(""); 
            t4.setText("");
            
            b3.setEnabled(false);
            b4.setEnabled(false);
            b1.setEnabled(true);
            b2.setEnabled(true);     
            return;            
        }
          if (e.getSource() == b4){            
            t1.setText("");
            t2.setText(""); 
            t3.setText(""); 
            t4.setText("");
            
            b3.setEnabled(false);
            b4.setEnabled(false);
            b1.setEnabled(false);
            b2.setEnabled(false);   
            
            
            return;            
        }
    }    
}