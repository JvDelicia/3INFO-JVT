/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
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
import java.text.SimpleDateFormat;
import java.text.ParseException;


public class Exe12 extends JFrame implements ActionListener{
    JLabel l1,pergunta;
    JButton b1, b2;
    JTextField t1;
    
    public static void main(String[] args) {
        JFrame janela = new Exe12();
        janela.setUndecorated(true);
        janela.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setVisible(true);
    }
    Exe12(){
        setTitle("Verificar Data válida");
        setBounds(700,250,500,150);
        getContentPane().setBackground(new Color(200,30,101));
        getContentPane().setLayout(new GridLayout(2,2));
       

        
        b1 = new JButton("Achar");
        b1.addActionListener(this);     
        b2 = new JButton("Limpar");
        b2.addActionListener(this);
        pergunta = new JLabel("pergunta");
        pergunta.setForeground(Color.black);
        pergunta.setFont(new Font("", Font.BOLD,14));
        pergunta.setText("Insira uma Data :");
        
        l1 = new JLabel("l1");
        l1.setForeground(Color.black);
        l1.setFont(new Font("", Font.BOLD,14));
        
        l1.setText("");

        
        t1 = new JTextField();
        
        add(pergunta);
        add(t1);
        add(b1);
        add(b2);
        

       
    }
    public void actionPerformed(ActionEvent e) {
        if (e.getSource()==b1){         
        try
        {
            SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
            sdf.setLenient(false);
            sdf.parse(t1.getText());
            t1.setText(t1.getText() + " - Data válida!");
        }
        
        catch(ParseException certo)
        {
            t1.setText("Data inválida!");
        }

            return;
        }
         if (e.getSource() == b2){            
            t1.setText("");

            return;
        }
    }
}
