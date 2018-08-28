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

public class Exe5 extends JFrame implements ActionListener{
    JLabel l1,l2,l3;
    JButton b1,b2;
    JTextField t1,t2,t3;
    public static void main (String[]args){
        JFrame f = new Exe5();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }
    public Exe5(){
        setTitle("Ciclista");
        setBounds(600,300,600,150);
        getContentPane().setBackground(new Color(237, 129, 186));
        getContentPane().setLayout(new GridLayout(4,2));
        l1 = new JLabel("Digite a quantidade de voltas feitas:");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 14));
        l2 = new JLabel("Digite o valor do diâmetro:");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 14));
        l3 = new JLabel("A distância percorrida foi de:");
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
        add(l3);add(t3);
        add(b1);add(b2);
        
    }
    
    public void actionPerformed(ActionEvent e){
        if(e.getSource()==b2){
            t1.setText("");
            t2.setText("");
            t3.setText("");
            t1.requestFocus();
            return;
        }
        
        double qtd_voltas,diametro,comp,result;
        qtd_voltas = Double.parseDouble(t1.getText());
        diametro = Double.parseDouble(t2.getText());
        comp =(Math.PI*diametro)/2;
        result = comp * qtd_voltas;
        t3.setText(""+result);
    }   
}