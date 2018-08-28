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


public class Exe1 extends JFrame implements ActionListener{
    JLabel l1,l2,l3;
    JButton b1,b2;
    JTextField t1,t2,t3;
    public Exe1(){
        setTitle("Valor");
        setBounds(600,300,350,150);
        getContentPane().setBackground(new Color(175,200,255));
        getContentPane().setLayout(new GridLayout(4,3));
        l1 = new JLabel("Valor:");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 14));
        l2 = new JLabel("Código:");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 14));
        l3 = new JLabel("Valor após desc:");
        l3.setForeground(Color.BLACK);
        l3.setFont(new Font("",Font.BOLD, 14));
        
        b1 = new JButton("Calcular");
        b1.addActionListener(this);
        b2 = new JButton("Limpar");
        b2.addActionListener(this);
        
        t1 = new JTextField();
        t2 = new JTextField();
        t3 = new JTextField();
        t3.setEditable(false);
        add(l1);add(t1);
        add(l2);add(t2);
        add(b1);add(b2);
        add(l3);add(t3);
        
    }
    public static void main (String[]args)
    {
        JFrame f = new Exe1();
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
            t1.requestFocus();
            return;
        }
        double n1 = 0,res = 0;
        int n2 = 0;
        try{
            n1 = Double.parseDouble(t1.getText());
            n2 = Integer.parseInt(t2.getText());
        }catch(NumberFormatException erro){t3.setText("Erro"); }
        if(e.getSource()==b1){
            switch(n2){
                case 1: res = n1 - (n1*0.05);break; 
                case 2: res = n1 - (n1*0.1);break;
                case 3: res = n1 - (n1*0.2);break;
                case 4: res = n1 - (n1*0.5);break;
                default:t3.setText("Código inválido");break;
            }
        }
        
        t3.setText(""+res);
    }
}
