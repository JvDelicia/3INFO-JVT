package atividade;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.awt.GridLayout;
import javax.swing.JFrame;

public class Atividade14v2 extends JFrame implements ItemListener {
    JLabel l1, l2, l3;
    JTextField t1;   
    JButton b1, b2;
     JRadioButton radio1,radio2,radio3;
     ButtonGroup radiogroup;
     float result, N1;
    
    public static void main(String[]args){
        JFrame f = new Atividade14v2();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }

    public Atividade14v2(){
        setTitle("Desconto");
        setBounds(550,250,700,350);
        getContentPane().setBackground(new Color(0,80,155));
        getContentPane().setLayout(new GridLayout(7,1));
        
        radio1 = new JRadioButton("Dinheiro - 5% de Desconto");
        radio2 = new JRadioButton("Cartão - Acréscimo de 10%");
        radio3 = new JRadioButton("Cheque - Acréscimo de 5%");
        radiogroup = new ButtonGroup();
        radiogroup.add(radio1);
        radiogroup.add(radio2);
        radiogroup.add(radio3);
        radio1.addItemListener(this);
        radio2.addItemListener(this);
        radio3.addItemListener(this);
       
        
        l1 = new JLabel("Escolhe ");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 20));
        
        l2 = new JLabel("Valor :");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 20));
        t1 = new JTextField();
        
        l3 = new JLabel("");
        l3.setForeground(Color.BLACK);
        l3.setFont(new Font("",Font.BOLD, 20));
        
        add(l2);add(t1); 
        
        add(t1);
        add(radio1); add(radio2); add(radio3);
        add(l3);
    }

    public void itemStateChanged(ItemEvent e) {
        try {
            N1 = Float.parseFloat(t1.getText());
            if (e.getSource()==radio1)
            result = (float) ((float) N1 - (N1* 0.05));;
            l3.setText("" + result);
            if (e.getSource()==radio2)
            result = (float) ((float) N1 + (N1* 0.1));
            l3.setText("" + result);
            if(e.getSource()==radio3)
            result = (float) ((float) N1 + (N1* 0.05));
            l3.setText("" + result);
        } catch(NumberFormatException erro) { }
    }       
}
