package Exercicios;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JRootPane;
import javax.swing.JTextField;

public class Exe6 extends JFrame implements ActionListener
{
    JLabel l1,l2,l3,l4;
    JButton b1,b2;
    JTextField t1,t2,t3,t4;
    int i=0;
    
    public static void main (String[]args)
    {
        JFrame f = new Exe6();
        f.setUndecorated(true);
        f.getRootPane().setWindowDecorationStyle(JRootPane.FRAME);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.setVisible(true);
    }
    public Exe6()
    {
        setTitle("Operações Matemáticas");
        setBounds(600,300,500,250);
        getContentPane().setBackground(new Color(15,32,60));
        getContentPane().setLayout(new GridLayout(5,2));
        
        l1 = new JLabel("Digite  o primeiro valor:");
        l1.setForeground(Color.BLACK);
        l1.setFont(new Font("",Font.BOLD, 14));
        l2 = new JLabel("Digite  o segundo valor:");
        l2.setForeground(Color.BLACK);
        l2.setFont(new Font("",Font.BOLD, 14));
        l3 = new JLabel("Digite  o terceiro valor:");
        l3.setForeground(Color.BLACK);
        l3.setFont(new Font("",Font.BOLD, 14));
        l4 = new JLabel("Digite  o quarto valor:");
        l4.setForeground(Color.BLACK);
        l4.setFont(new Font("",Font.BOLD, 14));

        b1 = new JButton("Calcular");
        b1.addActionListener(this);
        b2 = new JButton("Limpar");
        b2.addActionListener(this);
        t1 = new JTextField();
        t2 = new JTextField();
        t3 = new JTextField();
        t4 = new JTextField();
        
        add(l1);add(t1);
        add(l2);add(t2);
        add(l3);add(t3);
        add(l4);add(t4);
        add(b1);add(b2);
    }
    public void actionPerformed(ActionEvent e)
    {
        if(e.getSource()==b2){
            t1.setText("");
            t2.setText("");
            t3.setText("");
            t4.setText("");
            t1.requestFocus();
            return;
        }
        
        double v1, v2, v3, v4, media, somam, div1, div2, div3, div4;
        
        v1 = Double.parseDouble(t1.getText());
        v2 = Double.parseDouble(t2.getText());
        v3 = Double.parseDouble(t3.getText());
        v4 = Double.parseDouble(t4.getText());

        media = (v1 + v2 + v3 + v4)/4;
        somam = (v1 + v2 + v3 + v4);
        
        JOptionPane.showMessageDialog(rootPane,"Resultados:\nMedia:"+media
                            +"\nSomatório:"+somam
                            +"\nResto divisão 1:"+ somam%v1
                            +"\nResto divisão 2:"+ somam%v2
                            +"\nResto divisão 3:"+ somam%v3
                            +"\nResto divisão 4:"+ somam%v4);
        
    }
}   
