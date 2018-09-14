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

public class Exe8 extends JFrame{
    JLabel l1;
    public static void main(String[] args) {
        JFrame janela = new Exe8();
        janela.setUndecorated(true);
        janela.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setVisible(true);
    }
    static long fibo(int n) {
        if (n < 2) {
            return n;
        } else {
            return fibo(n -  1) + fibo(n - 2);
        }
    }
    Exe8(){
        
        setTitle("Fibonacci");
        setBounds(400,300,1050,90);
        getContentPane().setBackground(new Color(35, 88, 210));
        getContentPane().setLayout(new GridLayout(1,1));
        
        l1 = new JLabel("num1");
        l1.setForeground(Color.white);
        l1.setFont(new Font("", Font.BOLD,14));
        
        String texto = "";
        for (int i = 1; i <= 15; i++) {
           texto += (" ( " + i + " ) - " + fibo(i) + " \n  ");
        }
        l1.setText(texto);
        getContentPane().add(l1);
    }
}
