package Exercicios;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JRootPane;
import javax.swing.JTextField;


public class Exe2 extends JFrame implements ActionListener{
    JLabel l1,l2,l3,l4;
    JButton b1,b2;
    JTextField t1,t2,t3,t4;
    public Exe2(){
        setTitle("Calculadora");
        setBounds(450,280,800,200);
        getContentPane().setBackground(new Color(12,200,235));
        getContentPane().setLayout(new GridLayout(5,2));
        l1 = new JLabel("Primeiro Número");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 14));
        l2 = new JLabel("Segundo Número");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 14));
        l3 = new JLabel("Total");
        l3.setForeground(Color.BLACK);
        l3.setFont(new Font("",Font.BOLD, 14));
        l4 = new JLabel("A - Soma / B - Subtração / C - Multiplicação / D - Divisão");
        l4.setForeground(Color.BLACK);
        l4.setFont(new Font("",Font.BOLD, 14));
        
        b1 = new JButton("Calcular");
        b1.addActionListener(this);
        b2 = new JButton("Limpar");
        b2.addActionListener(this);
        t1 = new JTextField();
        t2 = new JTextField();
        t3 = new JTextField();
        t3.setEditable(false);
        t4 = new JTextField();
        add(l1);add(t1);
        add(l2);add(t2);
        add(b1);add(b2);
        add(l4);add(t4);
        add(l3);add(t3);
        add(b2);add(b1);
    }
    public static void main (String[]args)
    {
        JFrame f = new Exe2();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }
    public void actionPerformed(ActionEvent e){
        if(e.getSource()==b2){
            t1.setText("");
            t2.setText("");
            t3.setText("");
            t4.setText("");
            t1.requestFocus();
            return;
        }
        double n1 = 0,n2=0,res = 0;
        String l ="";
        try{
            n1 = Double.parseDouble(t1.getText());
            n2 = Double.parseDouble(t2.getText());
            l = t4.getText().toUpperCase();
        }catch(NumberFormatException erro){t3.setText("Erro"); }
        switch(l){
            case "A": res = n1 + n2;break; 
            case "B": res = n1 - n2;break;
            case "C": res = n1 * n2;break;
            case "D": res = n1 / n2;break;
            default:t3.setText("Código inválido");break;
        }
        t3.setText(""+res);
    }
}
