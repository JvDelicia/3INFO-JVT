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

public class Exe10 extends JFrame{
    JLabel l1;
    public static void main(String[] args) {
        JFrame janela = new Exe10();
        janela.setUndecorated(true);
        janela.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setVisible(true);
    }
    Exe10(){
        setTitle("Promo");
        setBounds(500,250,600,80);
        getContentPane().setBackground(new Color(67,162,234));
        getContentPane().setLayout(new GridLayout(1,1));
        
        l1 = new JLabel("num1");
        l1.setForeground(Color.black);
        l1.setFont(new Font("", Font.BOLD,14));
        
       Date d = new Date();
       if(d.getDay() == 0)
       {
           l1.setText( "Domingo é dia de comprar ar!!! Ainda mais com esse desconto de 100%!!!");
       }
       if(d.getDay() == 1)
       {
           l1.setText( "Segunda é dia de viver!!! Ainda mais com esse desconto de 30%!!!");
       }
       if(d.getDay() == 2)
       {
           l1.setText( "Terça é dia de dar um beijo no Leleo!!! Ainda mais com esse desconto de 30%!!!");
       }
       if(d.getDay() == 3)
       {
           l1.setText( "Quarta é dia de bater no gaymer!!! Ainda mais com esse desconto de 200%!!!");
       }
       if(d.getDay() == 4)
       {
           l1.setText( "Quinta é dia de pastel!!! Ainda mais com esse desconto de 80%!!!");
       }
       if(d.getDay() == 5)
       {
           l1.setText( "Sexta é dia de maldade!!! Ainda mais com esse desconto de 20%!!!");
       }
       if(d.getDay() == 6)
       {
           l1.setText( "Sábado é dia de comer b_ _ _ta!!! Ainda mais com esse desconto de 20%!!!");
       }
       getContentPane().add(l1);
    }
}
